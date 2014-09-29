﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace UpdatePatient
{
    /// <summary>
    ///The FeeCodeCheckMSP recording.
    /// </summary>
    [TestModule("cf08e6b1-e1b9-4dd7-aca1-be7f9696f79e", ModuleType.Recording, 1)]
    public partial class FeeCodeCheckMSP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UpdatePatientRepository repository.
        /// </summary>
        public static UpdatePatientRepository repo = UpdatePatientRepository.Instance;

        static FeeCodeCheckMSP instance = new FeeCodeCheckMSP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FeeCodeCheckMSP()
        {
            DefaultFeeCode = "15300";
            DefaultFeeCode2 = "15300";
            DefaultFeeCode3 = "15300";
            ServiceDate = "12/12/1954";
            ServiceFeeCode1 = "15300";
            ServiceFeeCode2 = "15300";
            ServiceFeeCode3 = "15300";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FeeCodeCheckMSP Instance
        {
            get { return instance; }
        }

#region Variables

        string _DefaultFeeCode;

        /// <summary>
        /// Gets or sets the value of variable DefaultFeeCode.
        /// </summary>
        [TestVariable("93d17f05-ab26-427c-a232-5f398b4e4bb8")]
        public string DefaultFeeCode
        {
            get { return _DefaultFeeCode; }
            set { _DefaultFeeCode = value; }
        }

        string _DefaultFeeCode2;

        /// <summary>
        /// Gets or sets the value of variable DefaultFeeCode2.
        /// </summary>
        [TestVariable("ed5181eb-0c8e-4c56-adce-9b501326882d")]
        public string DefaultFeeCode2
        {
            get { return _DefaultFeeCode2; }
            set { _DefaultFeeCode2 = value; }
        }

        string _DefaultFeeCode3;

        /// <summary>
        /// Gets or sets the value of variable DefaultFeeCode3.
        /// </summary>
        [TestVariable("3f7f3260-8fd7-456a-a37d-646912479e95")]
        public string DefaultFeeCode3
        {
            get { return _DefaultFeeCode3; }
            set { _DefaultFeeCode3 = value; }
        }

        string _ServiceDate;

        /// <summary>
        /// Gets or sets the value of variable ServiceDate.
        /// </summary>
        [TestVariable("00484e86-99b5-4749-8146-90df6862bf23")]
        public string ServiceDate
        {
            get { return _ServiceDate; }
            set { _ServiceDate = value; }
        }

        string _ServiceFeeCode1;

        /// <summary>
        /// Gets or sets the value of variable ServiceFeeCode1.
        /// </summary>
        [TestVariable("c75d74a1-c712-4b93-9f81-d12bdc4450b7")]
        public string ServiceFeeCode1
        {
            get { return _ServiceFeeCode1; }
            set { _ServiceFeeCode1 = value; }
        }

        string _ServiceFeeCode2;

        /// <summary>
        /// Gets or sets the value of variable ServiceFeeCode2.
        /// </summary>
        [TestVariable("5d9e915d-87e8-4747-a7d2-8e70f0c4f8e9")]
        public string ServiceFeeCode2
        {
            get { return _ServiceFeeCode2; }
            set { _ServiceFeeCode2 = value; }
        }

        string _ServiceFeeCode3;

        /// <summary>
        /// Gets or sets the value of variable ServiceFeeCode3.
        /// </summary>
        [TestVariable("c5b51751-3c24-456b-8abc-dacb3bb17bb3")]
        public string ServiceFeeCode3
        {
            get { return _ServiceFeeCode3; }
            set { _ServiceFeeCode3 = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.1.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.1.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem' at 15;6.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(0));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.Click("15;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}100' with focus on 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(1));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}100");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.SomeTdTag' at 43;2.", repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTagInfo, new RecordItemIndex(2));
            repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTag.Click("43;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$DefaultFeeCode) on item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, "Value", DefaultFeeCode);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem' at 15;6.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(4));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.Click("15;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}101' with focus on 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(5));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}101");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.SomeTdTag' at 43;2.", repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTagInfo, new RecordItemIndex(6));
            repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTag.Click("43;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$DefaultFeeCode2) on item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, "Value", DefaultFeeCode2);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem' at 15;6.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(8));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.Click("15;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}110' with focus on 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(9));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}110");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.SomeTdTag' at 43;2.", repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTagInfo, new RecordItemIndex(10));
            repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTag.Click("43;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$DefaultFeeCode3) on item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(11));
            Validate.Attribute(repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, "Value", DefaultFeeCode3);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.TxtServiceDate' at Center.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtServiceDateInfo, new RecordItemIndex(12));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtServiceDate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}' with focus on 'PLEXIAEMRTest3Modal.SearchBar.TxtServiceDate'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtServiceDateInfo, new RecordItemIndex(13));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtServiceDate.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable $ServiceDate with focus on 'PLEXIAEMRTest3Modal.SearchBar.TxtServiceDate'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtServiceDateInfo, new RecordItemIndex(14));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtServiceDate.PressKeys(ServiceDate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.SomeTdTag' at 43;2.", repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTagInfo, new RecordItemIndex(15));
            repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTag.Click("43;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem' at 15;6.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(16));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.Click("15;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}100' with focus on 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(17));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}100");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.SomeTdTag' at 43;2.", repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTagInfo, new RecordItemIndex(18));
            repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTag.Click("43;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$ServiceFeeCode1) on item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(19));
            Validate.Attribute(repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, "Value", ServiceFeeCode1);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem' at 15;6.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(20));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.Click("15;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}101' with focus on 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(21));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}101");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.SomeTdTag' at 43;2.", repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTagInfo, new RecordItemIndex(22));
            repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTag.Click("43;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$ServiceFeeCode2) on item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(23));
            Validate.Attribute(repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, "Value", ServiceFeeCode2);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem' at 15;6.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(24));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.Click("15;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}110' with focus on 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(25));
            repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}110");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.SomeTdTag' at 43;2.", repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTagInfo, new RecordItemIndex(26));
            repo.PLEXIAEMRTest3Modal.SearchBar.SomeTdTag.Click("43;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$ServiceFeeCode3) on item 'PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItem'.", repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, new RecordItemIndex(27));
            Validate.Attribute(repo.PLEXIAEMRTest3Modal.SearchBar.TxtBilledFeeItemInfo, "Value", ServiceFeeCode3);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PLEXIAEMRTest3Modal.SearchBar.BtnCancel2' at Center.", repo.PLEXIAEMRTest3Modal.SearchBar.BtnCancel2Info, new RecordItemIndex(28));
            repo.PLEXIAEMRTest3Modal.SearchBar.BtnCancel2.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
}
