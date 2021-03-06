using System;
using System.Collections.Generic;

namespace Baseline.FluentHttpExtensions
{
    /// <summary>
    /// Contains any and all extensions related to URLs.
    /// </summary>
    public static class UrlExtensions
    {
        /// <summary>
        /// Adds an additional path segment to the url specified when instantiating a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the additional path segment against.</param>
        /// <param name="pathSegment">The actual path segment.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithPathSegment(this HttpRequest request, short pathSegment)
        {
            return request.WithPathSegment(pathSegment.ToString());
        }

        /// <summary>
        /// Adds an additional path segment to the url specified when instantiating a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the additional path segment against.</param>
        /// <param name="pathSegment">The actual path segment.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithPathSegment(this HttpRequest request, ushort pathSegment)
        {
            return request.WithPathSegment(pathSegment.ToString());
        }

        /// <summary>
        /// Adds an additional path segment to the url specified when instantiating a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the additional path segment against.</param>
        /// <param name="pathSegment">The actual path segment.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithPathSegment(this HttpRequest request, int pathSegment)
        {
            return request.WithPathSegment(pathSegment.ToString());
        }

        /// <summary>
        /// Adds an additional path segment to the url specified when instantiating a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the additional path segment against.</param>
        /// <param name="pathSegment">The actual path segment.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithPathSegment(this HttpRequest request, uint pathSegment)
        {
            return request.WithPathSegment(pathSegment.ToString());
        }

        /// <summary>
        /// Adds an additional path segment to the url specified when instantiating a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the additional path segment against.</param>
        /// <param name="pathSegment">The actual path segment.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithPathSegment(this HttpRequest request, long pathSegment)
        {
            return request.WithPathSegment(pathSegment.ToString());
        }

        /// <summary>
        /// Adds an additional path segment to the url specified when instantiating a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the additional path segment against.</param>
        /// <param name="pathSegment">The actual path segment.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithPathSegment(this HttpRequest request, ulong pathSegment)
        {
            return request.WithPathSegment(pathSegment.ToString());
        }

        /// <summary>
        /// Adds an additional path segment to the url specified when instantiating a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the additional path segment against.</param>
        /// <param name="pathSegment">The actual path segment.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithPathSegment(this HttpRequest request, Guid pathSegment)
        {
            return request.WithPathSegment(pathSegment.ToString());
        }

        /// <summary>
        /// Adds an additional path segment to the url specified when instantiating a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the additional path segment against.</param>
        /// <param name="pathSegment">The actual path segment.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithPathSegment(this HttpRequest request, string pathSegment)
        {
            if (string.IsNullOrWhiteSpace(pathSegment))
            {
                throw new ArgumentNullException(nameof(pathSegment));
            }

            if (request.PathSegments == null)
            {
                request.PathSegments = new List<string>();
            }

            request.PathSegments.Add(pathSegment);

            return request;
        }

        /// <summary>
        /// Adds a query parameter to a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the query parameter against.</param>
        /// <param name="parameterName">The query parameter's name.</param>
        /// <param name="value">The query parameter's value.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithQueryParameter(this HttpRequest request, string parameterName, int value)
        {
            return request.WithQueryParameter(parameterName, value.ToString());
        }

        /// <summary>
        /// Adds a query parameter to a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the query parameter against.</param>
        /// <param name="parameterName">The query parameter's name.</param>
        /// <param name="value">The query parameter's value.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithQueryParameter(this HttpRequest request, string parameterName, uint value)
        {
            return request.WithQueryParameter(parameterName, value.ToString());
        }

        /// <summary>
        /// Adds a query parameter to a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the query parameter against.</param>
        /// <param name="parameterName">The query parameter's name.</param>
        /// <param name="value">The query parameter's value.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithQueryParameter(this HttpRequest request, string parameterName, short value)
        {
            return request.WithQueryParameter(parameterName, value.ToString());
        }

        /// <summary>
        /// Adds a query parameter to a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the query parameter against.</param>
        /// <param name="parameterName">The query parameter's name.</param>
        /// <param name="value">The query parameter's value.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithQueryParameter(this HttpRequest request, string parameterName, ushort value)
        {
            return request.WithQueryParameter(parameterName, value.ToString());
        }

        /// <summary>
        /// Adds a query parameter to a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the query parameter against.</param>
        /// <param name="parameterName">The query parameter's name.</param>
        /// <param name="value">The query parameter's value.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithQueryParameter(this HttpRequest request, string parameterName, long value)
        {
            return request.WithQueryParameter(parameterName, value.ToString());
        }

        /// <summary>
        /// Adds a query parameter to a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the query parameter against.</param>
        /// <param name="parameterName">The query parameter's name.</param>
        /// <param name="value">The query parameter's value.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithQueryParameter(this HttpRequest request, string parameterName, ulong value)
        {
            return request.WithQueryParameter(parameterName, value.ToString());
        }

        /// <summary>
        /// Adds a query parameter to a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the query parameter against.</param>
        /// <param name="parameterName">The query parameter's name.</param>
        /// <param name="value">The query parameter's value.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithQueryParameter(this HttpRequest request, string parameterName, Guid value)
        {
            return request.WithQueryParameter(parameterName, value.ToString());
        }

        /// <summary>
        /// Adds a query parameter to a <see cref="HttpRequest"/>.
        /// </summary>
        /// <param name="request">The http request to set the query parameter against.</param>
        /// <param name="parameterName">The query parameter's name.</param>
        /// <param name="value">The query parameter's value.</param>
        /// <returns>The current <see cref="HttpRequest"/>.</returns>
        public static HttpRequest WithQueryParameter(this HttpRequest request, string parameterName, string value)
        {
            if (request.QueryParameters == null)
            {
                request.QueryParameters = new List<(string, string)>();
            }

            if (!string.IsNullOrWhiteSpace(value))
            {
                request.QueryParameters.Add((parameterName, value));
            }

            return request;
        }
    }
}
