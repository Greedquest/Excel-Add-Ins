﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExcelAddIn1.System_Of_Linear_Equations {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SystemOfLinearEquations {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SystemOfLinearEquations() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExcelAddIn1.System_Of_Linear_Equations.SystemOfLinearEquations", typeof(SystemOfLinearEquations).Assembly);
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
        ///   Looks up a localized string similar to Answer vector rows must match coefficient matrix columns.
        /// </summary>
        internal static string AnswerVectorMustMatchCoeffMatrixColumns {
            get {
                return ResourceManager.GetString("AnswerVectorMustMatchCoeffMatrixColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Answer vector must contain only one column.
        /// </summary>
        internal static string AnswerVectorSingleColumn {
            get {
                return ResourceManager.GetString("AnswerVectorSingleColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid input.
        /// </summary>
        internal static string InvalidInputCaption {
            get {
                return ResourceManager.GetString("InvalidInputCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inputs need to be valid, correct cell references before continuing..
        /// </summary>
        internal static string InvalidInputText {
            get {
                return ResourceManager.GetString("InvalidInputText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-singular matrix.
        /// </summary>
        internal static string NonSingularMatrixCaption {
            get {
                return ResourceManager.GetString("NonSingularMatrixCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Matrix is non - singular and cannot be solved for.
        /// </summary>
        internal static string NonSingularMatrixText {
            get {
                return ResourceManager.GetString("NonSingularMatrixText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-square matrix.
        /// </summary>
        internal static string NonSquareMatrixCaption {
            get {
                return ResourceManager.GetString("NonSquareMatrixCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A non-square coefficient matrix cannot be solved for.
        /// </summary>
        internal static string NonSquareMatrixText {
            get {
                return ResourceManager.GetString("NonSquareMatrixText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select valid values for inputs and outputs.
        /// </summary>
        internal static string SelectValidInputs {
            get {
                return ResourceManager.GetString("SelectValidInputs", resourceCulture);
            }
        }
    }
}
