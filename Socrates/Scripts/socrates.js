$(document).ready(function () {
    $(":input[type='datetime']").each(function () {
        $(this).datepicker();
    })

    $(":input[data-autocomplete]").each(function () {
        $(this).autocomplete({ source: $(this).attr("data-autocomplete") })
    })

})