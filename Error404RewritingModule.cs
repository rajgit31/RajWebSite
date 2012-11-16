// Copyright (C) 2009 Xtensive LLC.
// All rights reserved.
// For conditions of distribution and use, see license.
// Created by: Alexander Ilyin
// http://www.codeproject.com/KB/aspnet/iis-aspnet-url-rewriting.aspx
// Created:    2009.07.17

using System.Web;
using System;
using System.Text;
using System.Reflection;

namespace RajSoftware
{
    /// <summary>
    /// Error404RewritingModule
    /// </summary>
    public class Error404RewritingModule
      : IHttpModule
    {
        private static readonly FieldInfo HttpMethodFieldInfo;
        private static readonly FieldInfo HttpVerbFieldInfo;

        /// <summary>
        /// Initializes a module and prepares it to handle requests.
        /// </summary>
        /// <param name="context">An <see cref="T:System.Web.HttpApplication"/> that provides access to the methods, properties, and events common to all application objects within an ASP.NET application</param>
        public void Init(HttpApplication context)
        {
            context.BeginRequest += OnBeginRequest;
        }

        /// <summary>
        /// Called when [begin request].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        static void OnBeginRequest(object sender, EventArgs e)
        {
            HttpContext httpContext = HttpContext.Current;
            HttpRequest httpRequest = httpContext.Request;
            //
            string targetPath = httpRequest.AppRelativeCurrentExecutionFilePath;
            if (!targetPath.StartsWith("~/Error404.axd", StringComparison.InvariantCultureIgnoreCase))
                return;
            //
            Uri requestedUrl = httpRequest.Url;
            var currentApplicationUrl = new Uri(requestedUrl, httpRequest.ApplicationPath);
            string initiallyRequestedUrl = ExtractInitiallyRequestedUrl(requestedUrl.Query);
            string initiallyRequestedVirtualPath = GetInitiallyRequestedVirtualPath(
              currentApplicationUrl, initiallyRequestedUrl);
            //
            if (initiallyRequestedVirtualPath != null)
            {
                // If rewriting is possible at all.
                string initiallyRequestedQuery = ExtractInitiallyRequestedQuery(initiallyRequestedUrl);
                if (String.IsNullOrEmpty(initiallyRequestedQuery))
                {
                    httpContext.RewritePath("~/Hack", "/", "a=b", true);
                    httpContext.RewritePath(initiallyRequestedVirtualPath, null, "", true);
                }
                else
                    httpContext.RewritePath(initiallyRequestedVirtualPath, null, initiallyRequestedQuery, true);

                if (!String.Equals(httpRequest.HttpMethod, "POST", StringComparison.InvariantCultureIgnoreCase))
                    if (httpRequest["__VIEWSTATE"] != null || httpRequest["__EVENTTARGET"] != null)
                    {
                        HttpMethodFieldInfo.SetValue(httpRequest, "POST");
                        HttpVerbFieldInfo.SetValue(httpRequest, 5); // 5 = POST
                    }
            }
        }

        private static string ExtractInitiallyRequestedUrl(string rawQueryUrl)
        {
            // IIS is assumed to send request like 404?http://myDomain.com/MyApplication
            int indexOfSemicolon = rawQueryUrl.IndexOf(';');
            if (indexOfSemicolon != -1)
                return rawQueryUrl.Substring(indexOfSemicolon + 1, rawQueryUrl.Length - indexOfSemicolon - 1);
            return null;
        }

        private static string ExtractInitiallyRequestedQuery(string query)
        {
            int indexOfQuestionMark = query.IndexOf('?');
            if (indexOfQuestionMark != -1)
                return query.Substring(indexOfQuestionMark + 1, query.Length - indexOfQuestionMark - 1);
            return null;
        }

        private static bool SegmentsAreEqual(string segment1, string segment2)
        {
            if (segment1.Length == segment2.Length)
                return segment1.Equals(segment2, StringComparison.InvariantCultureIgnoreCase);
            return segment1.Trim('/').Equals(segment2.Trim('/'), StringComparison.InvariantCultureIgnoreCase);
        }

        private static string GetInitiallyRequestedVirtualPath(Uri currentApplicationUrl, string initiallyRequestedUrl)
        {
            if (initiallyRequestedUrl == null)
                return null;
            var requestedUri = new Uri(initiallyRequestedUrl);
            bool requestedUrlMatchApplication = true;
            if (requestedUri.Segments.Length >= currentApplicationUrl.Segments.Length)
            {
                for (int i = 0; i < currentApplicationUrl.Segments.Length; i++)
                    if (!SegmentsAreEqual(currentApplicationUrl.Segments[i], requestedUri.Segments[i]))
                    {
                        requestedUrlMatchApplication = false;
                        break;
                    }
            }
            else
                requestedUrlMatchApplication = false;
            if (!requestedUrlMatchApplication)
                return null;

            var result = new StringBuilder(initiallyRequestedUrl.Length);
            if (requestedUri.Segments.Length == currentApplicationUrl.Segments.Length)
                result.Append("~/");
            else
            {
                for (int i = currentApplicationUrl.Segments.Length; i < requestedUri.Segments.Length; i++)
                {
                    string segment = requestedUri.Segments[i];
                    if (result.Length == 0)
                        if (segment.StartsWith("/"))
                            result.Append("~");
                        else
                            result.Append("~/");
                    result.Append(segment);
                }
            }
            return result.ToString();
        }

        /// <summary>
        /// Disposes of the resources (other than memory) used by the module that implements <see cref="T:System.Web.IHttpModule"/>.
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// Initializes the <see cref="Error404RewritingModule"/> class.
        /// </summary>
        static Error404RewritingModule()
        {
            HttpMethodFieldInfo = typeof(HttpRequest).GetField("_httpMethod", BindingFlags.Instance | BindingFlags.NonPublic);
            HttpVerbFieldInfo = typeof(HttpRequest).GetField("_httpVerb", BindingFlags.Instance | BindingFlags.NonPublic);
        }
    }
}