$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/EmployeeProfile/GetEmployeeProfileData",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Please select Employee</option>';
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].value + '">' + data[i].text + '</option>';
            }
            $('#EmployeeProfileDropdown').html(s);
        }
    });
});

function getEmployeeValue() {
    var myVal = $("#EmployeeProfileDropdown").val();
    $("#showEmployeeProfile").val(myVal);
}
