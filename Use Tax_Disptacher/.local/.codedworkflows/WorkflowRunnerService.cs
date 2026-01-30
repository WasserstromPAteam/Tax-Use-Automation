using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using UseTax_Disptacher;

[assembly: WorkflowRunnerServiceAttribute(typeof(UseTax_Disptacher.WorkflowRunnerService))]
namespace UseTax_Disptacher
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the SAP_Workflows/SAP_Login.xaml
        /// </summary>
        public bool SAP_Login(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\SAP_Login.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
            return (bool)result["out_Incorrect_Credentilas"];
        }

        /// <summary>
        /// Invokes the SAP_Workflows/SAP_Login.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public bool SAP_Login(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\SAP_Login.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
            return (bool)result["out_Incorrect_Credentilas"];
        }

        /// <summary>
        /// Invokes the SAP_Workflows/Execute_FBL3N.xaml
        /// </summary>
        public void Execute_FBL3N(System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable in_Dt_FBL3N)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\Execute_FBL3N.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_Dt_FBL3N", in_Dt_FBL3N}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SAP_Workflows/Execute_FBL3N.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Execute_FBL3N(System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable in_Dt_FBL3N, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\Execute_FBL3N.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_Dt_FBL3N", in_Dt_FBL3N}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(string in_OrchestratorQueueName, string in_OrchestratorQueueFolder)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_OrchestratorQueueName", in_OrchestratorQueueName}, {"in_OrchestratorQueueFolder", in_OrchestratorQueueFolder}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(string in_OrchestratorQueueName, string in_OrchestratorQueueFolder, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_OrchestratorQueueName", in_OrchestratorQueueName}, {"in_OrchestratorQueueFolder", in_OrchestratorQueueFolder}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
        public void WorkflowTestCaseTemplate()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void WorkflowTestCaseTemplate(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
        public void ProcessTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ProcessTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
        public void InitAllApplicationsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplicationsTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/Filepath.xaml
        /// </summary>
        public void Filepath()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\Filepath.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/Filepath.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Filepath(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\Filepath.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SAP_Workflows/SAP_LogoutORBack.xaml
        /// </summary>
        public void SAP_LogoutORBack(string in_Operationtype)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\SAP_LogoutORBack.xaml", new Dictionary<string, object>{{"in_Operationtype", in_Operationtype}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SAP_Workflows/SAP_LogoutORBack.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void SAP_LogoutORBack(string in_Operationtype, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\SAP_LogoutORBack.xaml", new Dictionary<string, object>{{"in_Operationtype", in_Operationtype}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SAP_Workflows/Export_SE16.xaml
        /// </summary>
        public void Export_SE16(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\Export_SE16.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SAP_Workflows/Export_SE16.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Export_SE16(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\Export_SE16.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string TakeScreenshot(string in_Folder, string io_FilePath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, isolated, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Excel_Workflows/Create_ExcelTemplate.xaml
        /// </summary>
        public System.Data.DataTable Create_ExcelTemplate(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Excel_Workflows\Create_ExcelTemplate.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["Out_Dt_FBL3N"];
        }

        /// <summary>
        /// Invokes the Excel_Workflows/Create_ExcelTemplate.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Create_ExcelTemplate(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Excel_Workflows\Create_ExcelTemplate.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["Out_Dt_FBL3N"];
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
        public void MainTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void MainTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
        public void GetTransactionDataTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetTransactionDataTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SAP_Workflows/SAP_MultipleSelection.xaml
        /// </summary>
        public void SAP_MultipleSelection(string in_str_ManufactureItemNum)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\SAP_MultipleSelection.xaml", new Dictionary<string, object>{{"in_str_ManufactureItemNum", in_str_ManufactureItemNum}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SAP_Workflows/SAP_MultipleSelection.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void SAP_MultipleSelection(string in_str_ManufactureItemNum, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\SAP_MultipleSelection.xaml", new Dictionary<string, object>{{"in_str_ManufactureItemNum", in_str_ManufactureItemNum}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SAP_Workflows/FBL3N_FileExport.xaml
        /// </summary>
        public void FBL3N_FileExport(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\FBL3N_FileExport.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SAP_Workflows/FBL3N_FileExport.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void FBL3N_FileExport(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\FBL3N_FileExport.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SAP_Workflows/Execute_UseTaxQuery.xaml
        /// </summary>
        public System.Data.DataTable Execute_UseTaxQuery(System.Collections.Generic.Dictionary<string, object> in_Config, string In_MaterialNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\Execute_UseTaxQuery.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"In_MaterialNumber", In_MaterialNumber}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_Dt_LookupDoc"];
        }

        /// <summary>
        /// Invokes the SAP_Workflows/Execute_UseTaxQuery.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Execute_UseTaxQuery(System.Collections.Generic.Dictionary<string, object> in_Config, string In_MaterialNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\Execute_UseTaxQuery.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"In_MaterialNumber", In_MaterialNumber}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_Dt_LookupDoc"];
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public System.Data.DataTable InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_DtFBL3N"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_DtFBL3N"];
        }

        /// <summary>
        /// Invokes the Excel_Workflows/PrepareDocsToLookup.xaml
        /// </summary>
        public void PrepareDocsToLookup(System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable in_Dt_LookupDoc)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Excel_Workflows\PrepareDocsToLookup.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_Dt_LookupDoc", in_Dt_LookupDoc}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Excel_Workflows/PrepareDocsToLookup.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void PrepareDocsToLookup(System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable in_Dt_LookupDoc, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Excel_Workflows\PrepareDocsToLookup.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_Dt_LookupDoc", in_Dt_LookupDoc}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/ScrollTEST.xaml
        /// </summary>
        public void ScrollTEST()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ScrollTEST.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/ScrollTEST.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ScrollTEST(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ScrollTEST.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/Queue.xaml
        /// </summary>
        public void Queue()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\Queue.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/Queue.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Queue(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\Queue.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
        public void InitAllSettingsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllSettingsTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SAP_Workflows/Tcode SQ01 and select variant.xaml
        /// </summary>
        public System.Data.DataTable Tcode_SQ01_and_select_variant(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\Tcode SQ01 and select variant.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_Dt_LookupDoc"];
        }

        /// <summary>
        /// Invokes the SAP_Workflows/Tcode SQ01 and select variant.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Tcode_SQ01_and_select_variant(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SAP_Workflows\Tcode SQ01 and select variant.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_Dt_LookupDoc"];
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
        public void Process(UiPath.Core.QueueItem in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable in_Dt_FBL3N)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_TransactionItem", in_TransactionItem}, {"in_Config", in_Config}, {"in_Dt_FBL3N", in_Dt_FBL3N}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Process(UiPath.Core.QueueItem in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable in_Dt_FBL3N, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_TransactionItem", in_TransactionItem}, {"in_Config", in_Config}, {"in_Dt_FBL3N", in_Dt_FBL3N}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void KillAllProcesses(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CloseAllApplications(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}