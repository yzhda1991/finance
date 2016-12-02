﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    
    using Frapid.WebsiteBuilder;
    using MixERP.Finance;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/JournalEntry/Index.cshtml")]
    public partial class _Views_Tasks_JournalEntry_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_JournalEntry_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Tasks\JournalEntry\Index.cshtml"
  
    ViewBag.Title = "Journal Entries";
    Layout = ViewBag.FinanceLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n<style>\r\n    .modal iframe {\r\n        width: 100%;\r\n        border: none;\r\n    " +
"    height: 700px;\r\n    }\r\n</style>\r\n<div");

WriteLiteral(" class=\"ui attached page segment\"");

WriteLiteral(" style=\"min-height: 100%; padding: 3em;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(">Journal Entries</div>\r\n    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"ui basic buttons\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" id=\"AddNewButton\"");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" style=\"\"");

WriteLiteral(" href=\"/dashboard/finance/tasks/journal/entry/new\"");

WriteLiteral(">\r\n            Add New\r\n        </a>\r\n        ");

WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"ui icon top left pointing dropdown basic button\"");

WriteLiteral(" id=\"ExportDropDown\"");

WriteLiteral(" tabindex=\"0\"");

WriteLiteral(">\r\n            <span>\r\n                Export\r\n            </span>\r\n            <" +
"div");

WriteLiteral(" class=\"menu\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"header\"");

WriteLiteral(">\r\n                    Export This Document\r\n                </div>\r\n            " +
"    <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createDoc();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file word outline blue icon\"");

WriteLiteral("></i> Export to Doc\r\n                </a>\r\n                <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createXls();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file excel outline green icon\"");

WriteLiteral("></i> Export to Excel\r\n                </a>\r\n                <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createPDF();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file pdf outline red icon\"");

WriteLiteral("></i> Export to PDF\r\n                </a>\r\n            </div>\r\n        </div>\r\n  " +
"      <a");

WriteLiteral(" id=\"PrintButton\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"print()\"");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(">\r\n            Print\r\n        </a>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"ui stackable form segment\"");

WriteLiteral(" id=\"Annotation\"");

WriteLiteral(" style=\"\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"eight fields\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" class=\"date\"");

WriteLiteral(" placeholder=\"From\"");

WriteLiteral(" id=\"FromInputDate\"");

WriteLiteral(" data-expression=\"BOY\"");

WriteLiteral(" title=\"From\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" class=\"date\"");

WriteLiteral(" placeholder=\"To\"");

WriteLiteral(" id=\"ToInputDate\"");

WriteLiteral(" data-expression=\"EOY\"");

WriteLiteral(" title=\"To\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"TranId\"");

WriteLiteral(" id=\"TranIdInputText\"");

WriteLiteral(" title=\"TranId\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"TranCode\"");

WriteLiteral(" id=\"TranCodeInputText\"");

WriteLiteral(" title=\"TranCode\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"ReferenceNumber\"");

WriteLiteral(" id=\"ReferenceNumberInputText\"");

WriteLiteral(" title=\"ReferenceNumber\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"StatementReference\"");

WriteLiteral(" id=\"StatementReferenceInputText\"");

WriteLiteral(" title=\"StatementReference\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"PostedBy\"");

WriteLiteral(" id=\"PostedByInputText\"");

WriteLiteral(" title=\"PostedBy\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"eight fields\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Office\"");

WriteLiteral(" id=\"OfficeInputText\"");

WriteLiteral(" title=\"Office\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Status\"");

WriteLiteral(" id=\"StatusInputText\"");

WriteLiteral(" title=\"Status\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"VerifiedBy\"");

WriteLiteral(" id=\"VerifiedByInputText\"");

WriteLiteral(" title=\"VerifiedBy\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Reason\"");

WriteLiteral(" id=\"ReasonInputText\"");

WriteLiteral(" title=\"Reason\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field hidden\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"UserId\"");

WriteLiteral(" id=\"UserIdInputText\"");

WriteLiteral(" title=\"UserId\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field hidden\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"OfficeId\"");

WriteLiteral(" id=\"OfficeIdInputText\"");

WriteLiteral(" title=\"OfficeId\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui green button\"");

WriteLiteral(" id=\"ShowButton\"");

WriteLiteral(">Show</div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n    <table");

WriteLiteral(" id=\"JournalView\"");

WriteLiteral(" class=\"ui table segment\"");

WriteLiteral(@">
        <thead>
            <tr>
                <th>Actions</th>
                <th>TranId</th>
                <th>TranCode</th>
                <th>Value Date</th>
                <th>Book Date</th>
                <th>Ref#</th>
                <th>Statement Reference</th>
                <th>Posted By</th>
                <th>Office</th>
                <th>Status</th>
                <th>Verified By</th>
                <th>Verified On</th>
                <th>Reason</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
</div>

<div");

WriteLiteral(" class=\"ui large journal advice modal\"");

WriteLiteral(">\r\n    <i");

WriteLiteral(" class=\"close icon\"");

WriteLiteral("></i>\r\n    <iframe></iframe>\r\n</div>\r\n<script>\r\n    $(document).ready(function(){" +
"})\r\n    function displayTable(target, model) {\r\n        target.find(\"tbody\").htm" +
"l(\"\");\r\n        function getCell(text) {\r\n            var cell = $(\"<td />\");\r\n\r" +
"\n            cell.text(text || \"\");\r\n\r\n            return cell;\r\n        };\r\n\r\n " +
"       function getActionCell(tranId) {\r\n            var cell = $(\"<td />\");\r\n\r\n" +
"            var checklistAnchor = $(\"<a title=\'Checklist Window\'><i class=\'list " +
"icon\'></i></a>\");\r\n            checklistAnchor.attr(\"href\", \"/dashboard/finance/" +
"tasks/journal/checklist/\" + tranId);\r\n\r\n            var printAnchor = $(\"<a titl" +
"e=\'View Journal Advice\'><i class=\'print icon\'></i></a>\");\r\n            printAnch" +
"or.attr(\"href\", \"javascript:void(0);\");\r\n            printAnchor.attr(\"onclick\"," +
" \"showJournalAdvice(\" + tranId + \");\");\r\n\r\n            cell.append(checklistAnch" +
"or);\r\n            cell.append(printAnchor);\r\n            return cell;\r\n        }" +
";\r\n\r\n        $.each(model, function () {\r\n            var item = this;\r\n\r\n      " +
"      var row = $(\"<tr />\");\r\n\r\n            row.append(getActionCell(item.Transa" +
"ctionMasterId));\r\n            row.append(getCell(item.TransactionMasterId));\r\n  " +
"          row.append(getCell(item.TransactionCode));\r\n            row.append(get" +
"Cell(item.ValueDate));\r\n            row.append(getCell(item.BookDate));\r\n       " +
"     row.append(getCell(item.ReferenceNumber));\r\n            row.append(getCell(" +
"item.StatementReference));\r\n            row.append(getCell(item.PostedBy));\r\n   " +
"         row.append(getCell(item.Office));\r\n            row.append(getCell(item." +
"Status));\r\n            row.append(getCell(item.VerifiedBy));\r\n            row.ap" +
"pend(getCell(item.VerifiedOn));\r\n            row.append(getCell(item.Reason));\r\n" +
"\r\n            target.find(\"tbody\").append(row);\r\n        });\r\n    };\r\n    functi" +
"on processQuery() {\r\n        function getModel() {\r\n            var model = wind" +
"ow.serializeForm($(\"#Annotation\"));\r\n            model.Book = \"Journal Entry\";\r\n" +
"\r\n            return model;\r\n        };\r\n\r\n        function displayGrid(target) " +
"{\r\n            function request(model) {\r\n                var url = \"/dashboard/" +
"finance/tasks/journal/view\";\r\n                var data = JSON.stringify(model);\r" +
"\n                return window.getAjaxRequest(url, \"POST\", data);\r\n            }" +
";\r\n\r\n\r\n            var model = getModel();\r\n\r\n            var ajax = request(mod" +
"el);\r\n\r\n            ajax.success(function (response) {\r\n                displayT" +
"able(target, response);\r\n                target.removeClass(\"loading\");\r\n       " +
"     });\r\n\r\n            ajax.fail(function (xhr) {\r\n                alert(JSON.s" +
"tringify(xhr));\r\n            });\r\n        };\r\n\r\n        var view = $(\"#JournalVi" +
"ew\").addClass(\"loading\");\r\n\r\n        displayGrid(view);\r\n    };\r\n\r\n    $(\"#ShowB" +
"utton\").unbind(\"click\").bind(\"click\", function () {\r\n        processQuery();\r\n  " +
"  });\r\n\r\n    loadDatepicker();\r\n    \r\n\r\n    function showJournalAdvice(tranId) {" +
"\r\n        $(\".journal.advice.modal iframe\").attr(\"src\", \"/dashboard/reports/sour" +
"ce/Areas/MixERP.Finance/Reports/JournalEntry.xml?transaction_master_id=\" + tranI" +
"d);\r\n\r\n        setTimeout(function () {\r\n            $(\".journal.advice.modal\")\r" +
"\n                .modal(\'setting\', \'transition\', \'horizontal flip\')\r\n           " +
"     .modal({\r\n                    blurring: true\r\n                })\r\n         " +
"       .modal(\"show\");\r\n\r\n        }, 300);\r\n    };\r\n\r\n    setTimeout(function ()" +
" {\r\n        processQuery();\r\n    }, 1000);\r\n</script>");

        }
    }
}
#pragma warning restore 1591