﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProdeFutbol.Web.Resources {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProdeFutbol.Web.Resources.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Confirm Email.
        /// </summary>
        public static string ConfirmEmail {
            get {
                return ResourceManager.GetString("ConfirmEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a A Confirmation email was sent. Please confirm your account and log into the App..
        /// </summary>
        public static string ConfirmEmailMessage {
            get {
                return ResourceManager.GetString("ConfirmEmailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a To allow the user, please click on this link:.
        /// </summary>
        public static string ConfirmEmailSubject {
            get {
                return ResourceManager.GetString("ConfirmEmailSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Incorrect current password..
        /// </summary>
        public static string IncorrectCurrentPassword {
            get {
                return ResourceManager.GetString("IncorrectCurrentPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Match is already closed..
        /// </summary>
        public static string MatchAlreadyClosed {
            get {
                return ResourceManager.GetString("MatchAlreadyClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a You cannot record the prediction, because the match has already started..
        /// </summary>
        public static string MatchAlreadyStarts {
            get {
                return ResourceManager.GetString("MatchAlreadyStarts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Match doesn&apos;t exists..
        /// </summary>
        public static string MatchDoesntExists {
            get {
                return ResourceManager.GetString("MatchDoesntExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The password was changed successfully!.
        /// </summary>
        public static string PasswordChangedSuccess {
            get {
                return ResourceManager.GetString("PasswordChangedSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a  Recover Password.
        /// </summary>
        public static string RecoverPassword {
            get {
                return ResourceManager.GetString("RecoverPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a An email with instructions to change the password was sent..
        /// </summary>
        public static string RecoverPasswordMessage {
            get {
                return ResourceManager.GetString("RecoverPasswordMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a To reset the password click in this link:.
        /// </summary>
        public static string RecoverPasswordSubject {
            get {
                return ResourceManager.GetString("RecoverPasswordSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Tournament doesn&apos;t exists..
        /// </summary>
        public static string TournamentDoesntExists {
            get {
                return ResourceManager.GetString("TournamentDoesntExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a User already exists..
        /// </summary>
        public static string UserAlreadyExists {
            get {
                return ResourceManager.GetString("UserAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a User doesn&apos;t exists..
        /// </summary>
        public static string UserDoesntExists {
            get {
                return ResourceManager.GetString("UserDoesntExists", resourceCulture);
            }
        }
    }
}
