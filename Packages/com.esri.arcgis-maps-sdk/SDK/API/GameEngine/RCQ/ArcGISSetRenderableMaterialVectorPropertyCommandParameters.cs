// COPYRIGHT 1995-2023 ESRI
// TRADE SECRETS: ESRI PROPRIETARY AND CONFIDENTIAL
// Unpublished material - all rights reserved under the
// Copyright Laws of the United States and applicable international
// laws, treaties, and conventions.
//
// For additional information, contact:
// Attn: Contracts and Legal Department
// Environmental Systems Research Institute, Inc.
// 380 New York Street
// Redlands, California 92373
// USA
//
// email: legal@esri.com
using System.Runtime.InteropServices;

namespace Esri.GameEngine.RCQ
{
    /// <summary>
    /// A set vector parameter value render command.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ArcGISSetRenderableMaterialVectorPropertyCommandParameters
    {
        /// <summary>
        /// The material parameter of this render command.
        /// </summary>
        public uint RenderableId;
        
        /// <summary>
        /// The material vector property parameter of this render command.
        /// </summary>
        public ArcGISMaterialVectorProperty MaterialVectorProperty;
        
        /// <summary>
        /// The value parameter of this render command.
        /// </summary>
        public GameEngine.Math.ArcGISDoubleVector4 Value;
    }
}