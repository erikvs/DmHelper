#pragma checksum "F:\dotNET\NewApp\DMHelper\DMHelper\Views\GenerateEncounterPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF260B82A6026B523AD2A3ED62C8D7BDF39F6FA43AB67B43084DDBB8FAFF23BD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using WinRT;

namespace DMHelper.Views
{
    partial class GenerateEncounterPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_Primitives_Selector_SelectedValue(global::Microsoft.UI.Xaml.Controls.Primitives.Selector obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedValue = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBox_Text(global::Microsoft.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class GenerateEncounterPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IGenerateEncounterPage_Bindings
        {
            private global::DMHelper.Views.GenerateEncounterPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.ComboBox obj4;
            private global::Microsoft.UI.Xaml.Controls.ComboBox obj5;
            private global::Microsoft.UI.Xaml.Controls.ComboBox obj6;
            private global::Microsoft.UI.Xaml.Controls.ComboBox obj7;
            private global::Microsoft.UI.Xaml.Controls.TextBox obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4SelectedValueDisabled = false;
            private static bool isobj5SelectedValueDisabled = false;
            private static bool isobj6SelectedValueDisabled = false;
            private static bool isobj7SelectedValueDisabled = false;
            private static bool isobj8TextDisabled = false;

            private GenerateEncounterPage_obj1_BindingsTracking bindingsTracking;

            public GenerateEncounterPage_obj1_Bindings()
            {
                this.bindingsTracking = new GenerateEncounterPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 98 && columnNumber == 31)
                {
                    isobj4SelectedValueDisabled = true;
                }
                else if (lineNumber == 82 && columnNumber == 31)
                {
                    isobj5SelectedValueDisabled = true;
                }
                else if (lineNumber == 67 && columnNumber == 32)
                {
                    isobj6SelectedValueDisabled = true;
                }
                else if (lineNumber == 52 && columnNumber == 32)
                {
                    isobj7SelectedValueDisabled = true;
                }
                else if (lineNumber == 40 && columnNumber == 31)
                {
                    isobj8TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Views\GenerateEncounterPage.xaml line 93
                        this.obj4 = target.As<Microsoft.UI.Xaml.Controls.ComboBox>();
                        this.bindingsTracking.RegisterTwoWayListener_4(this.obj4);
                        break;
                    case 5: // Views\GenerateEncounterPage.xaml line 77
                        this.obj5 = target.As<Microsoft.UI.Xaml.Controls.ComboBox>();
                        this.bindingsTracking.RegisterTwoWayListener_5(this.obj5);
                        break;
                    case 6: // Views\GenerateEncounterPage.xaml line 62
                        this.obj6 = target.As<Microsoft.UI.Xaml.Controls.ComboBox>();
                        this.bindingsTracking.RegisterTwoWayListener_6(this.obj6);
                        break;
                    case 7: // Views\GenerateEncounterPage.xaml line 47
                        this.obj7 = target.As<Microsoft.UI.Xaml.Controls.ComboBox>();
                        this.bindingsTracking.RegisterTwoWayListener_7(this.obj7);
                        break;
                    case 8: // Views\GenerateEncounterPage.xaml line 35
                        this.obj8 = target.As<Microsoft.UI.Xaml.Controls.TextBox>();
                        this.bindingsTracking.RegisterTwoWayListener_8(this.obj8);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IGenerateEncounterPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = newDataRoot.As<DMHelper.Views.GenerateEncounterPage>();
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DMHelper.Views.GenerateEncounterPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_selectedEnvironment(obj.selectedEnvironment, phase);
                        this.Update_difficulty(obj.difficulty, phase);
                        this.Update_playerLevel(obj.playerLevel, phase);
                        this.Update_playerAmount(obj.playerAmount, phase);
                        this.Update_encounterName(obj.encounterName, phase);
                    }
                }
            }
            private void Update_selectedEnvironment(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\GenerateEncounterPage.xaml line 93
                    if (!isobj4SelectedValueDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_Selector_SelectedValue(this.obj4, obj, null);
                    }
                }
            }
            private void Update_difficulty(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\GenerateEncounterPage.xaml line 77
                    if (!isobj5SelectedValueDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_Selector_SelectedValue(this.obj5, obj, null);
                    }
                }
            }
            private void Update_playerLevel(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\GenerateEncounterPage.xaml line 62
                    if (!isobj6SelectedValueDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_Selector_SelectedValue(this.obj6, obj, null);
                    }
                }
            }
            private void Update_playerAmount(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\GenerateEncounterPage.xaml line 47
                    if (!isobj7SelectedValueDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_Selector_SelectedValue(this.obj7, obj, null);
                    }
                }
            }
            private void Update_encounterName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\GenerateEncounterPage.xaml line 35
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBox_Text(this.obj8, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_4_SelectedValue()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.selectedEnvironment = (global::System.String)this.obj4.SelectedValue;
                    }
                }
            }
            private void UpdateTwoWay_5_SelectedValue()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.difficulty = (global::System.String)this.obj5.SelectedValue;
                    }
                }
            }
            private void UpdateTwoWay_6_SelectedValue()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.playerLevel = (global::System.Int32)this.obj6.SelectedValue;
                    }
                }
            }
            private void UpdateTwoWay_7_SelectedValue()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.playerAmount = (global::System.Int32)this.obj7.SelectedValue;
                    }
                }
            }
            private void UpdateTwoWay_8_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.encounterName = this.obj8.Text;
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class GenerateEncounterPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<GenerateEncounterPage_obj1_Bindings> weakRefToBindingObj; 

                public GenerateEncounterPage_obj1_BindingsTracking(GenerateEncounterPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<GenerateEncounterPage_obj1_Bindings>(obj);
                }

                public GenerateEncounterPage_obj1_Bindings TryGetBindingObject()
                {
                    GenerateEncounterPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                }

                public void RegisterTwoWayListener_4(global::Microsoft.UI.Xaml.Controls.ComboBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedValueProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_4_SelectedValue();
                        }
                    });
                }
                public void RegisterTwoWayListener_5(global::Microsoft.UI.Xaml.Controls.ComboBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedValueProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_5_SelectedValue();
                        }
                    });
                }
                public void RegisterTwoWayListener_6(global::Microsoft.UI.Xaml.Controls.ComboBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedValueProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_6_SelectedValue();
                        }
                    });
                }
                public void RegisterTwoWayListener_7(global::Microsoft.UI.Xaml.Controls.ComboBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedValueProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_7_SelectedValue();
                        }
                    });
                }
                public void RegisterTwoWayListener_8(global::Microsoft.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_8_Text();
                        }
                    };
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\GenerateEncounterPage.xaml line 10
                {
                    this.ContentArea = target.As<Microsoft.UI.Xaml.Controls.Grid>();
                }
                break;
            case 3: // Views\GenerateEncounterPage.xaml line 110
                {
                    global::Microsoft.UI.Xaml.Controls.Button element3 = target.As<Microsoft.UI.Xaml.Controls.Button>();
                    ((global::Microsoft.UI.Xaml.Controls.Button)element3).Click += this.generateEncounter;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\GenerateEncounterPage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    GenerateEncounterPage_obj1_Bindings bindings = new GenerateEncounterPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

