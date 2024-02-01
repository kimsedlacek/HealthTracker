// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

{
    "Logging": {
        "LogLevel": {
            "Default": "Information",
                "Microsoft.AspNetCore": "Warning"
        }
    },
    "AllowedHosts": "*"
}

document.addEventListener("DOMContentLoaded", function () {
    // Get the table element
    const table = document.getElementById("data-table");

    // Add a scroll event listener to handle scrolling
    table.parentElement.addEventListener("scroll", function () {
        // Get the left column cells
        const leftColumnCells = table.querySelectorAll(".left-column");

        // Iterate through each left column cell and update its left offset
        leftColumnCells.forEach(function (cell) {
            cell.style.left = `${table.parentElement.scrollLeft}px`;
        });
    });
});
