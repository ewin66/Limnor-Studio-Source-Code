﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LimnorDatabase.DataTransfer {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LimnorDatabase.DataTransfer.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?php
        ///class DataSourceTextFile
        ///{
        ///	public $filepath;
        ///	public $delimiter;
        ///	public $hasHeader;
        ///	public $errorMessage;
        ///	private function popField(&amp;$sIn)
        ///	{
        ///		if (strlen($sIn) == 0)
        ///			return &quot;&quot;;
        ///		$startIndex = 0;
        ///		$qi2 = -1;
        ///		$qi = strpos($sIn,&apos;&quot;&apos;);
        ///		if ($qi &gt;= 0)
        ///		{
        ///			$qi2 = strpos($sIn,&apos;&quot;&apos;, qi + 1);
        ///		}
        ///		$nTab = -1;
        ///		while (true)
        ///		{
        ///			switch ($this-&gt;delimiter)
        ///			{
        ///				case &quot;,&quot;:
        ///					$nTab = strpos($sIn,&apos;,&apos;, $startIndex);
        ///					break;
        ///				case &quot;\t&quot;:
        ///					$nTab = strpos($sIn [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string dataTransfer_php {
            get {
                return ResourceManager.GetString("dataTransfer_php", resourceCulture);
            }
        }
    }
}
