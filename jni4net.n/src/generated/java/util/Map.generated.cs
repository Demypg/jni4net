//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Map {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int hashCode();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
        global::java.lang.Object put(global::java.lang.Object par0, global::java.lang.Object par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void clear();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        bool equals(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Set;")]
        global::java.util.Set entrySet();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Ljava/lang/Object;")]
        global::java.lang.Object get(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Map;)V")]
        void putAll(global::java.util.Map par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int size();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Collection;")]
        global::java.util.Collection values();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Ljava/lang/Object;")]
        global::java.lang.Object remove(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        bool containsKey(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        bool containsValue(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isEmpty();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Set;")]
        global::java.util.Set keySet();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Map_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.@__Map.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.util.Map))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.util.Map))]
    internal sealed partial class @__Map : global::java.lang.Object, global::java.util.Map {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode0;
        
        internal static global::net.sf.jni4net.jni.MethodId _put1;
        
        internal static global::net.sf.jni4net.jni.MethodId _clear2;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals3;
        
        internal static global::net.sf.jni4net.jni.MethodId _entrySet4;
        
        internal static global::net.sf.jni4net.jni.MethodId _get5;
        
        internal static global::net.sf.jni4net.jni.MethodId _putAll6;
        
        internal static global::net.sf.jni4net.jni.MethodId _size7;
        
        internal static global::net.sf.jni4net.jni.MethodId _values8;
        
        internal static global::net.sf.jni4net.jni.MethodId _remove9;
        
        internal static global::net.sf.jni4net.jni.MethodId _containsKey10;
        
        internal static global::net.sf.jni4net.jni.MethodId _containsValue11;
        
        internal static global::net.sf.jni4net.jni.MethodId _isEmpty12;
        
        internal static global::net.sf.jni4net.jni.MethodId _keySet13;
        
        protected @__Map(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.util.@__Map.staticClass = @__class;
            global::java.util.@__Map._hashCode0 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "hashCode", "()I");
            global::java.util.@__Map._put1 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.@__Map._clear2 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "clear", "()V");
            global::java.util.@__Map._equals3 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::java.util.@__Map._entrySet4 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "entrySet", "()Ljava/util/Set;");
            global::java.util.@__Map._get5 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.@__Map._putAll6 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "putAll", "(Ljava/util/Map;)V");
            global::java.util.@__Map._size7 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "size", "()I");
            global::java.util.@__Map._values8 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "values", "()Ljava/util/Collection;");
            global::java.util.@__Map._remove9 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.@__Map._containsKey10 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
            global::java.util.@__Map._containsValue11 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
            global::java.util.@__Map._isEmpty12 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "isEmpty", "()Z");
            global::java.util.@__Map._keySet13 = @__env.GetMethodID(global::java.util.@__Map.staticClass, "keySet", "()Ljava/util/Set;");
        }
        
        public int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.util.@__Map._hashCode0)));
        }
        
        public global::java.lang.Object put(global::java.lang.Object par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.@__Map._put1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1)));
        }
        
        public void clear() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.util.@__Map._clear2);
        }
        
        public bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Map._equals3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        public global::java.util.Set entrySet() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.@__Map._entrySet4));
        }
        
        public global::java.lang.Object get(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.@__Map._get5, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
        }
        
        public void putAll(global::java.util.Map par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.util.@__Map._putAll6, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Map>(@__env, par0));
        }
        
        public int size() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.util.@__Map._size7)));
        }
        
        public global::java.util.Collection values() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.@__Map._values8));
        }
        
        public global::java.lang.Object remove(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.@__Map._remove9, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
        }
        
        public bool containsKey(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Map._containsKey10, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        public bool containsValue(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Map._containsValue11, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        public bool isEmpty() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Map._isEmpty12)));
        }
        
        public global::java.util.Set keySet() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.@__Map._keySet13));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Map);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "hashCode", "hashCode0", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "put", "put1", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "clear", "clear2", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "equals", "equals3", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "entrySet", "entrySet4", "()Ljava/util/Set;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "get", "get5", "(Ljava/lang/Object;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "putAll", "putAll6", "(Ljava/util/Map;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "size", "size7", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "values", "values8", "()Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "remove", "remove9", "(Ljava/lang/Object;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "containsKey", "containsKey10", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "containsValue", "containsValue11", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isEmpty", "isEmpty12", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "keySet", "keySet13", "()Ljava/util/Set;"));
            return methods;
        }
        
        private static int hashCode0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return ((int)(@__real.hashCode()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(int);
        }
        
        private static global::net.sf.jni4net.utils.JniHandle put1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;
            // (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.put(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par1)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static void clear2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            @__real.clear();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static bool equals3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return ((bool)(@__real.equals(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static global::net.sf.jni4net.utils.JniHandle entrySet4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Set;
            // ()Ljava/util/Set;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Set>(@__env, @__real.entrySet());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static global::net.sf.jni4net.utils.JniHandle get5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)Ljava/lang/Object;
            // (Ljava/lang/Object;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.get(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static void putAll6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/util/Map;)V
            // (Ljava/util/Map;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            @__real.putAll(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static int size7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return ((int)(@__real.size()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(int);
        }
        
        private static global::net.sf.jni4net.utils.JniHandle values8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, @__real.values());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static global::net.sf.jni4net.utils.JniHandle remove9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)Ljava/lang/Object;
            // (Ljava/lang/Object;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.remove(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static bool containsKey10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return ((bool)(@__real.containsKey(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static bool containsValue11(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return ((bool)(@__real.containsValue(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static bool isEmpty12(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return ((bool)(@__real.isEmpty()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static global::net.sf.jni4net.utils.JniHandle keySet13(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Set;
            // ()Ljava/util/Set;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Map @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Set>(@__env, @__real.keySet());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.util.@__Map(@__env);
            }
        }
    }
    #endregion
}
