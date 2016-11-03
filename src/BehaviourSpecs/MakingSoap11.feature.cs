﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BehaviourSpecs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class MakingSoap11Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MakingSoap11.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MakingSoap11", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "MakingSoap11")))
            {
                BehaviourSpecs.MakingSoap11Feature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 010 - Should create a well-formatted SOAP 1.1 envelope with a head" +
            "er")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_010_ShouldCreateAWell_FormattedSOAP1_1EnvelopeWithAHeader()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 010 - Should create a well-formatted SOAP 1.1 envelope with a head" +
                    "er", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.When("a SOAP envelope with a header is built", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 5
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 020 - Should create a well-formatted SOAP 1.1 envelope with a body" +
            "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_020_ShouldCreateAWell_FormattedSOAP1_1EnvelopeWithABody()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 020 - Should create a well-formatted SOAP 1.1 envelope with a body" +
                    "", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.When("a SOAP envelope with a body is built", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 021 - Should create a well-formatted SOAP 1.1 envelope when more t" +
            "han one non-fault body entry is added")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_021_ShouldCreateAWell_FormattedSOAP1_1EnvelopeWhenMoreThanOneNon_FaultBodyEntryIsAdded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 021 - Should create a well-formatted SOAP 1.1 envelope when more t" +
                    "han one non-fault body entry is added", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
testRunner.When("more than one non-fault body entry is added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 030 - Should create a well-formatted SOAP 1.1 envelope with a head" +
            "er and body")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_030_ShouldCreateAWell_FormattedSOAP1_1EnvelopeWithAHeaderAndBody()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 030 - Should create a well-formatted SOAP 1.1 envelope with a head" +
                    "er and body", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
testRunner.When("a SOAP envelope with a header and body is built", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 040 - Should create a well-formatted SOAP 1.1 envelope with a faul" +
            "t")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_040_ShouldCreateAWell_FormattedSOAP1_1EnvelopeWithAFault()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 040 - Should create a well-formatted SOAP 1.1 envelope with a faul" +
                    "t", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
testRunner.When("a SOAP envelope with a fault is built", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 050 - Should allow the standard SOAP Encoding namespace to be set")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_050_ShouldAllowTheStandardSOAPEncodingNamespaceToBeSet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 050 - Should allow the standard SOAP Encoding namespace to be set", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
testRunner.When("a SOAP envelope with the standard soap encoding is built", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 051 - Should allow the SOAP Encoding namespace to be customised")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_051_ShouldAllowTheSOAPEncodingNamespaceToBeCustomised()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 051 - Should allow the SOAP Encoding namespace to be customised", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
testRunner.When("a SOAP envelope with a customised soap encoding is built", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 090 - Should error when the body is specified as a fault more than" +
            " once")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_090_ShouldErrorWhenTheBodyIsSpecifiedAsAFaultMoreThanOnce()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 090 - Should error when the body is specified as a fault more than" +
                    " once", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
testRunner.When("the body is specified twice as a fault", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
testRunner.Then("there is an error notification about the body being specified more than once", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 091 - Should error when the body is specified twice - as a fault a" +
            "nd then directly as a body")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_091_ShouldErrorWhenTheBodyIsSpecifiedTwice_AsAFaultAndThenDirectlyAsABody()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 091 - Should error when the body is specified twice - as a fault a" +
                    "nd then directly as a body", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
testRunner.When("the body is specified twice - as a fault and then directly as a body entry", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
testRunner.Then("there is an error notification about the body being specified more than once", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 092 - Should error when the body is specified twice - directly as " +
            "a body and then as a fault")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_092_ShouldErrorWhenTheBodyIsSpecifiedTwice_DirectlyAsABodyAndThenAsAFault()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 092 - Should error when the body is specified twice - directly as " +
                    "a body and then as a fault", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
testRunner.When("the body is specified twice - directly as a body entry and then as a fault", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
testRunner.Then("there is an error notification about the body being specified more than once", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 101 - Should make a SOAP body from an XML Object - with no XML att" +
            "ribute")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_101_ShouldMakeASOAPBodyFromAnXMLObject_WithNoXMLAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 101 - Should make a SOAP body from an XML Object - with no XML att" +
                    "ribute", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
testRunner.When("a SOAP envelope with a body entry from an object with no XML attribute is built", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 102 - Should make a SOAP body from an XML Object - with an XML Roo" +
            "t attribute")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_102_ShouldMakeASOAPBodyFromAnXMLObject_WithAnXMLRootAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 102 - Should make a SOAP body from an XML Object - with an XML Roo" +
                    "t attribute", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
testRunner.When("a SOAP envelope with a body entry from an object with an XML Root attribute is bu" +
                    "ilt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 103 - Should make a SOAP body from an XML Object - with an XML Typ" +
            "e attribute")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_103_ShouldMakeASOAPBodyFromAnXMLObject_WithAnXMLTypeAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 103 - Should make a SOAP body from an XML Object - with an XML Typ" +
                    "e attribute", ((string[])(null)));
#line 53
this.ScenarioSetup(scenarioInfo);
#line 54
testRunner.When("a SOAP envelope with a body entry from an object with an XML Type attribute is bu" +
                    "ilt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 104 - Should make a SOAP body from an XML Object - with an XML Roo" +
            "t attribute - using the given XML element name and existing root attribute names" +
            "pace")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_104_ShouldMakeASOAPBodyFromAnXMLObject_WithAnXMLRootAttribute_UsingTheGivenXMLElementNameAndExistingRootAttributeNamespace()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 104 - Should make a SOAP body from an XML Object - with an XML Roo" +
                    "t attribute - using the given XML element name and existing root attribute names" +
                    "pace", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line 58
testRunner.When("a SOAP envelope with a body entry from an object with an XML Root attribute is bu" +
                    "ilt - with a given XML element name and blank namespace", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MakingSoap11 - 105 - Should make a SOAP body from an XML Object - with an XML Roo" +
            "t attribute - using the given XML element name and given element namespace")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MakingSoap11")]
        public virtual void MakingSoap11_105_ShouldMakeASOAPBodyFromAnXMLObject_WithAnXMLRootAttribute_UsingTheGivenXMLElementNameAndGivenElementNamespace()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakingSoap11 - 105 - Should make a SOAP body from an XML Object - with an XML Roo" +
                    "t attribute - using the given XML element name and given element namespace", ((string[])(null)));
#line 61
this.ScenarioSetup(scenarioInfo);
#line 62
testRunner.When("a SOAP envelope with a body entry from an object with an XML Root attribute is bu" +
                    "ilt - with a given XML element name and namespace", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
testRunner.Then("the SOAP envelope is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion