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