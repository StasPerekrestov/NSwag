﻿//-----------------------------------------------------------------------
// <copyright file="RegisteredSwaggerDocument.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/NSwag/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using NSwag.Generation.AspNetCore;

namespace NSwag.AspNetCore
{
    /// <summary>A Swagger/OpenAPI document generator registration.</summary>
    public class OpenApiDocumentRegistration
    {
        /// <summary>Initializes a new instance of the <see cref="OpenApiDocumentRegistration"/> class.</summary>
        /// <param name="documentName">The document name.</param>
        /// <param name="generator">The document generator.</param>
        public OpenApiDocumentRegistration(string documentName, AspNetCoreOpenApiDocumentGenerator generator)
        {
            DocumentName = documentName;
            Generator = generator;
        }

        /// <summary>Gets the document name.</summary>
        public string DocumentName { get; }

        /// <summary>Gets the document generator.</summary>
        public AspNetCoreOpenApiDocumentGenerator Generator { get; }
    }
}
