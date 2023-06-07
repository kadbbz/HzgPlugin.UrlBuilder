/// <reference path="../Declarations/forguncy.d.ts" />
/// <reference path="../Declarations/forguncy.Plugin.d.ts" />

class UrlBuilderCommand extends Forguncy.Plugin.CommandBase{
    execute() {
        let pageName = this.evaluateFormula(this.CommandParam.PageName);
        let outParamaterName = this.CommandParam.OutParamaterName; 
        let urlPairs = this.CommandParam.UrlParamaterPairs;

        let rootPath = window.location.origin + Forguncy.StaticData.ForguncyRoot;

        let pageUrl = rootPath + pageName;

        let me = this;

        if (urlPairs && urlPairs.length > 0) {

            pageUrl += "?";

            urlPairs.forEach(function (v) {
                pageUrl += encodeURIComponent(me.evaluateFormula(v.Name));
                pageUrl += "=";
                pageUrl += encodeURIComponent(me.evaluateFormula(v.Value));
                pageUrl += "&";
            });

            pageUrl = pageUrl.substring(0, pageUrl.length - 1);
        } 


        if (outParamaterName && outParamaterName != "") {
            Forguncy.CommandHelper.setVariableValue(outParamaterName, pageUrl);
        } else {
            this.log("OutParamaterName was not set, the value is: " + pageUrl);
        }
    }
}

Forguncy.Plugin.CommandFactory.registerCommand("UrlBuilder.UrlBuilderCommand, UrlBuilder", UrlBuilderCommand);
