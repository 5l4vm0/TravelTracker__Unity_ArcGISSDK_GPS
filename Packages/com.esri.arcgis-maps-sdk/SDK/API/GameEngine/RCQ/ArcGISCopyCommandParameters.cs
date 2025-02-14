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
    /// A copy render command.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct ArcGISCopyCommandParameters
    {
        /// <summary>
        /// The source parameter of this render command.
        /// </summary>
        public uint SourceId;
        
        /// <summary>
        /// Id of the render target to be used as the output of the copy.
        /// </summary>
        public uint TargetId;
        
        /// <summary>
        /// The region parameter of this render command.
        /// </summary>
        public GameEngine.Math.ArcGISVector4 Region;
    }
}