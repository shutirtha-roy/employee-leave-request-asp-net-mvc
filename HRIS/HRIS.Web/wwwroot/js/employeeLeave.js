var dataTable;

$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/LeaveType/GetData",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Please select Leave Type</option>';
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].id + '">' + data[i].title + '</option>';
            }
            $('#LeaveTypeDropdown').html(s);
        }
    });

    loadEmployeeLeaveDataTable();
});

function getValue() {
    var myVal = $("#LeaveTypeDropdown").val();
    $("#showLeaveType").val(myVal);
}

function loadEmployeeLeaveDataTable() {
    dataTable = $('#tblEmployeeLeaveData').DataTable({
        "ajax": {
            "url": "/EmployeeLeave/GetAll"
        },
        "columns": [
            { "data": "leaveDate", "width": "50%" },
            { "data": "remarks", "width": "50%" }
        ]
    });
}












var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/LeaveType/GetAll"
        },
        "columns": [
            { "data": "title", "width": "100%" },
        ]
    });
}