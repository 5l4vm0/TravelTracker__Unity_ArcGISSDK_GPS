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
namespace Esri.Standard
{
    public enum ArcGISRuntimeClient
    {
        /// <summary>
        /// Unity.
        /// </summary>
        Unity = 1,
        
        /// <summary>
        /// Unreal Engine.
        /// </summary>
        UnrealEngine = 2,
        
        /// <summary>
        /// Native.
        /// </summary>
        Native = 3,
        
        /// <summary>
        /// No runtime client.
        /// </summary>
        None = -1
    };
}