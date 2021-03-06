﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Torshify.Origo.Shell.ImageService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NotLoggedInFault", Namespace="http://schemas.datacontract.org/2004/07/Torshify.Origo.Contracts.V1")]
    [System.SerializableAttribute()]
    public partial class NotLoggedInFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.torshify/v1", ConfigurationName="ImageService.ImageService")]
    public interface ImageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.torshify/v1/ImageService/GetAlbumImage", ReplyAction="http://schemas.torshify/v1/ImageService/GetAlbumImageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Torshify.Origo.Shell.ImageService.NotLoggedInFault), Action="http://schemas.torshify/v1/ImageService/GetAlbumImageNotLoggedInFaultFault", Name="NotLoggedInFault", Namespace="http://schemas.datacontract.org/2004/07/Torshify.Origo.Contracts.V1")]
        System.IO.Stream GetAlbumImage(string link);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://schemas.torshify/v1/ImageService/GetAlbumImage", ReplyAction="http://schemas.torshify/v1/ImageService/GetAlbumImageResponse")]
        System.IAsyncResult BeginGetAlbumImage(string link, System.AsyncCallback callback, object asyncState);
        
        System.IO.Stream EndGetAlbumImage(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.torshify/v1/ImageService/GetTrackImage", ReplyAction="http://schemas.torshify/v1/ImageService/GetTrackImageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Torshify.Origo.Shell.ImageService.NotLoggedInFault), Action="http://schemas.torshify/v1/ImageService/GetTrackImageNotLoggedInFaultFault", Name="NotLoggedInFault", Namespace="http://schemas.datacontract.org/2004/07/Torshify.Origo.Contracts.V1")]
        System.IO.Stream GetTrackImage(string link);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://schemas.torshify/v1/ImageService/GetTrackImage", ReplyAction="http://schemas.torshify/v1/ImageService/GetTrackImageResponse")]
        System.IAsyncResult BeginGetTrackImage(string link, System.AsyncCallback callback, object asyncState);
        
        System.IO.Stream EndGetTrackImage(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.torshify/v1/ImageService/GetArtistImage", ReplyAction="http://schemas.torshify/v1/ImageService/GetArtistImageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Torshify.Origo.Shell.ImageService.NotLoggedInFault), Action="http://schemas.torshify/v1/ImageService/GetArtistImageNotLoggedInFaultFault", Name="NotLoggedInFault", Namespace="http://schemas.datacontract.org/2004/07/Torshify.Origo.Contracts.V1")]
        System.IO.Stream GetArtistImage(string link);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://schemas.torshify/v1/ImageService/GetArtistImage", ReplyAction="http://schemas.torshify/v1/ImageService/GetArtistImageResponse")]
        System.IAsyncResult BeginGetArtistImage(string link, System.AsyncCallback callback, object asyncState);
        
        System.IO.Stream EndGetArtistImage(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.torshify/v1/ImageService/GetImage", ReplyAction="http://schemas.torshify/v1/ImageService/GetImageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Torshify.Origo.Shell.ImageService.NotLoggedInFault), Action="http://schemas.torshify/v1/ImageService/GetImageNotLoggedInFaultFault", Name="NotLoggedInFault", Namespace="http://schemas.datacontract.org/2004/07/Torshify.Origo.Contracts.V1")]
        System.IO.Stream GetImage(string link);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://schemas.torshify/v1/ImageService/GetImage", ReplyAction="http://schemas.torshify/v1/ImageService/GetImageResponse")]
        System.IAsyncResult BeginGetImage(string link, System.AsyncCallback callback, object asyncState);
        
        System.IO.Stream EndGetImage(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ImageServiceChannel : Torshify.Origo.Shell.ImageService.ImageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAlbumImageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAlbumImageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.IO.Stream Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.IO.Stream)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetTrackImageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetTrackImageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.IO.Stream Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.IO.Stream)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetArtistImageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetArtistImageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.IO.Stream Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.IO.Stream)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetImageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetImageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.IO.Stream Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.IO.Stream)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImageServiceClient : System.ServiceModel.ClientBase<Torshify.Origo.Shell.ImageService.ImageService>, Torshify.Origo.Shell.ImageService.ImageService {
        
        private BeginOperationDelegate onBeginGetAlbumImageDelegate;
        
        private EndOperationDelegate onEndGetAlbumImageDelegate;
        
        private System.Threading.SendOrPostCallback onGetAlbumImageCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetTrackImageDelegate;
        
        private EndOperationDelegate onEndGetTrackImageDelegate;
        
        private System.Threading.SendOrPostCallback onGetTrackImageCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetArtistImageDelegate;
        
        private EndOperationDelegate onEndGetArtistImageDelegate;
        
        private System.Threading.SendOrPostCallback onGetArtistImageCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetImageDelegate;
        
        private EndOperationDelegate onEndGetImageDelegate;
        
        private System.Threading.SendOrPostCallback onGetImageCompletedDelegate;
        
        public ImageServiceClient() {
        }
        
        public ImageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetAlbumImageCompletedEventArgs> GetAlbumImageCompleted;
        
        public event System.EventHandler<GetTrackImageCompletedEventArgs> GetTrackImageCompleted;
        
        public event System.EventHandler<GetArtistImageCompletedEventArgs> GetArtistImageCompleted;
        
        public event System.EventHandler<GetImageCompletedEventArgs> GetImageCompleted;
        
        public System.IO.Stream GetAlbumImage(string link) {
            return base.Channel.GetAlbumImage(link);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAlbumImage(string link, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAlbumImage(link, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IO.Stream EndGetAlbumImage(System.IAsyncResult result) {
            return base.Channel.EndGetAlbumImage(result);
        }
        
        private System.IAsyncResult OnBeginGetAlbumImage(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string link = ((string)(inValues[0]));
            return this.BeginGetAlbumImage(link, callback, asyncState);
        }
        
        private object[] OnEndGetAlbumImage(System.IAsyncResult result) {
            System.IO.Stream retVal = this.EndGetAlbumImage(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAlbumImageCompleted(object state) {
            if ((this.GetAlbumImageCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAlbumImageCompleted(this, new GetAlbumImageCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAlbumImageAsync(string link) {
            this.GetAlbumImageAsync(link, null);
        }
        
        public void GetAlbumImageAsync(string link, object userState) {
            if ((this.onBeginGetAlbumImageDelegate == null)) {
                this.onBeginGetAlbumImageDelegate = new BeginOperationDelegate(this.OnBeginGetAlbumImage);
            }
            if ((this.onEndGetAlbumImageDelegate == null)) {
                this.onEndGetAlbumImageDelegate = new EndOperationDelegate(this.OnEndGetAlbumImage);
            }
            if ((this.onGetAlbumImageCompletedDelegate == null)) {
                this.onGetAlbumImageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAlbumImageCompleted);
            }
            base.InvokeAsync(this.onBeginGetAlbumImageDelegate, new object[] {
                        link}, this.onEndGetAlbumImageDelegate, this.onGetAlbumImageCompletedDelegate, userState);
        }
        
        public System.IO.Stream GetTrackImage(string link) {
            return base.Channel.GetTrackImage(link);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetTrackImage(string link, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetTrackImage(link, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IO.Stream EndGetTrackImage(System.IAsyncResult result) {
            return base.Channel.EndGetTrackImage(result);
        }
        
        private System.IAsyncResult OnBeginGetTrackImage(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string link = ((string)(inValues[0]));
            return this.BeginGetTrackImage(link, callback, asyncState);
        }
        
        private object[] OnEndGetTrackImage(System.IAsyncResult result) {
            System.IO.Stream retVal = this.EndGetTrackImage(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetTrackImageCompleted(object state) {
            if ((this.GetTrackImageCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetTrackImageCompleted(this, new GetTrackImageCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetTrackImageAsync(string link) {
            this.GetTrackImageAsync(link, null);
        }
        
        public void GetTrackImageAsync(string link, object userState) {
            if ((this.onBeginGetTrackImageDelegate == null)) {
                this.onBeginGetTrackImageDelegate = new BeginOperationDelegate(this.OnBeginGetTrackImage);
            }
            if ((this.onEndGetTrackImageDelegate == null)) {
                this.onEndGetTrackImageDelegate = new EndOperationDelegate(this.OnEndGetTrackImage);
            }
            if ((this.onGetTrackImageCompletedDelegate == null)) {
                this.onGetTrackImageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetTrackImageCompleted);
            }
            base.InvokeAsync(this.onBeginGetTrackImageDelegate, new object[] {
                        link}, this.onEndGetTrackImageDelegate, this.onGetTrackImageCompletedDelegate, userState);
        }
        
        public System.IO.Stream GetArtistImage(string link) {
            return base.Channel.GetArtistImage(link);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetArtistImage(string link, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetArtistImage(link, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IO.Stream EndGetArtistImage(System.IAsyncResult result) {
            return base.Channel.EndGetArtistImage(result);
        }
        
        private System.IAsyncResult OnBeginGetArtistImage(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string link = ((string)(inValues[0]));
            return this.BeginGetArtistImage(link, callback, asyncState);
        }
        
        private object[] OnEndGetArtistImage(System.IAsyncResult result) {
            System.IO.Stream retVal = this.EndGetArtistImage(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetArtistImageCompleted(object state) {
            if ((this.GetArtistImageCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetArtistImageCompleted(this, new GetArtistImageCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetArtistImageAsync(string link) {
            this.GetArtistImageAsync(link, null);
        }
        
        public void GetArtistImageAsync(string link, object userState) {
            if ((this.onBeginGetArtistImageDelegate == null)) {
                this.onBeginGetArtistImageDelegate = new BeginOperationDelegate(this.OnBeginGetArtistImage);
            }
            if ((this.onEndGetArtistImageDelegate == null)) {
                this.onEndGetArtistImageDelegate = new EndOperationDelegate(this.OnEndGetArtistImage);
            }
            if ((this.onGetArtistImageCompletedDelegate == null)) {
                this.onGetArtistImageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetArtistImageCompleted);
            }
            base.InvokeAsync(this.onBeginGetArtistImageDelegate, new object[] {
                        link}, this.onEndGetArtistImageDelegate, this.onGetArtistImageCompletedDelegate, userState);
        }
        
        public System.IO.Stream GetImage(string link) {
            return base.Channel.GetImage(link);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetImage(string link, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetImage(link, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IO.Stream EndGetImage(System.IAsyncResult result) {
            return base.Channel.EndGetImage(result);
        }
        
        private System.IAsyncResult OnBeginGetImage(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string link = ((string)(inValues[0]));
            return this.BeginGetImage(link, callback, asyncState);
        }
        
        private object[] OnEndGetImage(System.IAsyncResult result) {
            System.IO.Stream retVal = this.EndGetImage(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetImageCompleted(object state) {
            if ((this.GetImageCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetImageCompleted(this, new GetImageCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetImageAsync(string link) {
            this.GetImageAsync(link, null);
        }
        
        public void GetImageAsync(string link, object userState) {
            if ((this.onBeginGetImageDelegate == null)) {
                this.onBeginGetImageDelegate = new BeginOperationDelegate(this.OnBeginGetImage);
            }
            if ((this.onEndGetImageDelegate == null)) {
                this.onEndGetImageDelegate = new EndOperationDelegate(this.OnEndGetImage);
            }
            if ((this.onGetImageCompletedDelegate == null)) {
                this.onGetImageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetImageCompleted);
            }
            base.InvokeAsync(this.onBeginGetImageDelegate, new object[] {
                        link}, this.onEndGetImageDelegate, this.onGetImageCompletedDelegate, userState);
        }
    }
}
