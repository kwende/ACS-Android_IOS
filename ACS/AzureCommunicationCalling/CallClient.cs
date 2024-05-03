using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Util.Concurrent;

namespace Com.Azure.Android.Communication.Calling
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.calling']/class[@name='CallClient']"
    public sealed partial class CallClient : global::Java.Lang.Object
    {
        [Register("createCallAgent", "(Landroid/content/Context;Lcom/azure/android/communication/common/CommunicationTokenCredential;)Ljava9/util/concurrent/CompletableFuture;", "")]
        public unsafe CompletableFuture CreateCallAgent(Context appContext, Com.Azure.Android.Communication.Common.CommunicationTokenCredential tokenCredential,
            Com.Azure.Android.Communication.Calling.CallAgentOptions callAgentOptions)
        {
            const string __id = "createCallAgent.(Landroid/content/Context;Lcom/azure/android/communication/common/CommunicationTokenCredential;)Ljava9/util/concurrent/CompletableFuture;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue(appContext);
                __args[1] = new JniArgumentValue(tokenCredential);
                __args[2] = new JniArgumentValue(callAgentOptions);

                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);

                return global::Java.Lang.Object.GetObject<CompletableFuture>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }
}

