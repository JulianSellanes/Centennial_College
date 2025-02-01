document.addEventListener("DOMContentLoaded", () => {
    const form = document.getElementById("table-form");
    const tableContainer = document.getElementById("table-container");

    form.addEventListener("submit", (_event) => {
        _event.preventDefault();

        const rows = parseInt(document.getElementById("rows").value);
        const columns = parseInt(document.getElementById("columns").value);

        if(isNaN(rows) || isNaN(columns) || rows <= 0 || columns <= 0) return;

        generateTable(rows, columns);
    });

    function generateTable(_rows, _columns)
    {
        tableContainer.innerHTML = "";

        const table = document.createElement("table");

        if(_rows == 8 && _columns == 8)
        {
            for (let i = 1; i <= _rows; i++) {
                const row = document.createElement("tr");
                row.style.backgroundColor = "green";

                for (let j = 1; j <= _columns; j++) {
                    const data = document.createElement("td");
                    data.style.padding = "30px";

                    if(i == 3 || i == 4)
                        if(j == 2 || j == 3 || j == 6 | j == 7)
                            data.style.backgroundColor = "black";

                    if(i == 5)
                        if(j == 4 || j == 5)
                            data.style.backgroundColor = "black";

                    if(i == 6 || i == 7)
                        if(j == 3 || j == 4 || j == 5 || j == 6)
                            data.style.backgroundColor = "black";

                    if(i == 8)
                        if(j == 3 || j == 6)
                            data.style.backgroundColor = "black";
    
                    row.appendChild(data);
                }

                table.appendChild(row);
            }
        }
        else
        {
            for (let i = 1; i <= _rows; i++) {
                const row = document.createElement("tr");
                row.style.backgroundColor = "white";

                for (let j = 1; j <= _columns; j++) {
                    const data = document.createElement("td");
                    data.style.padding = "8px";
                    data.textContent = `Row: ${i} Col: ${j}`;
    
                    row.appendChild(data);
                }
    
                table.appendChild(row);
            }
        }

        tableContainer.appendChild(table);
    }
});