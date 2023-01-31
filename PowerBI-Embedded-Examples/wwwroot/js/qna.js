// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// ----------------------------------------------------------------------------

$(function () {
    var models = window["powerbi-client"].models;
    var reportContainer = $("#report-container").get(0);

    $("#filter").prop("disabled", true);
    $("#remove-filter").prop("disabled", true);

    var report = null;

    $.ajax({
        type: "GET",
        url: "/embedinfo/getembedqnainfo",
        success: function (data) {
            embedParams = $.parseJSON(data);
            reportLoadConfig = {
                type: 'qna',
                tokenType: models.TokenType.Embed,
                accessToken: embedParams.EmbedToken.Token,
                // You can embed different reports as per your need
                embedUrl: embedParams.EmbedQnA[0].EmbedUrl,
                viewMode: models.QnaMode.ResultOnly,
                datasetIds: embedParams.EmbedQnA[0].DatasetIds,
                question: 'Count of Unique Patients'

                // Enable this setting to remove gray shoulders from embedded report
                // settings: {
                //     background: models.BackgroundType.Transparent
                // }
            };

            // Use the token expiry to regenerate Embed token for seamless end user experience
            // Refer https://aka.ms/RefreshEmbedToken
            tokenExpiry = embedParams.EmbedToken.Expiration;

            // Embed Power BI report when Access token and Embed URL are available
            report = powerbi.embed(reportContainer, reportLoadConfig);

            // Clear any other loaded handler events
            report.off("loaded");

            // Triggers when a report schema is successfully loaded
            report.on("loaded", function () {
                console.log("Report load successful");
            });

            // Clear any other rendered handler events
            report.off("rendered");

            // Triggers when a report is successfully embedded in UI
            report.on("rendered", function () {
                console.log("Report render successful");
                $("#filter").prop("disabled", false);
                $("#remove-filter").prop("disabled", false);
            });

            // Clear any other error handler events
            report.off("error");
            
            // Handle embed errors
            report.on("error", function (event) {
                var errorMsg = event.detail;
            
                // Use errorMsg variable to log error in any destination of choice
                console.error(errorMsg);
                return;
            });
        },
        error: function (err) {
            
            // Show error container
            var errorContainer = $(".error-container");
            $(".embed-container").hide();
            errorContainer.show();
            
            // Format error message
            var errMessageHtml = "<strong> Error Details: </strong> <br/>" + err.responseText;
            errMessageHtml = errMessageHtml.split("\n").join("<br/>");

            // Show error message on UI
            errorContainer.append(errMessageHtml);
        }
    });

    $("#ask").on('click', function () {
        var question = $("#question").val();
        askQuestion(question);
    });
});

async function askQuestion(question) {
    let report = powerbi.get($("#report-container").get(0));
    await report.setQuestion(question);
}