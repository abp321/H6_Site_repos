function SetControlValue(ID, VALUE) {

    var canReturn = VALUE !== null && VALUE !== undefined;
    var control = document.getElementById(ID);
    if (canReturn) control.value = VALUE;
}

function GetControlValue(ID) {
    var control = document.getElementById(ID);
    var value = control.value;
    var canReturn = value !== null && value !== undefined;

    return canReturn ? value : "";
}

function GetControlHtml(ID) {
    return document.getElementById(ID).textContent;
}

async function InfoFunction(ID, VALUE, DISPLAYTIME) {

    var canReturn = VALUE !== null && VALUE !== undefined;
    var control = document.getElementById(ID);
    if (canReturn) {
        control.value = VALUE;
        
        await sleep(DISPLAYTIME);
        control.value = "";
    }
}

function DISPLAY(VALUE) {
    alert(VALUE);
}

function FileSaveAs(filename, fileContent) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:text/plain;charset=utf-8," + encodeURIComponent(fileContent)
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

function GetCellValue(element) {
    if (element !== null && element !== undefined) {
        cells = element.getElementsByTagName('td');
        for (var i = 0, len = cells.length; i < len; i++) {

            cells[i].onclick = function () {
                //alert(this.innerHTML);
                var value = this.innerHTML;

                var canReturn = value !== null && value !== undefined;

                if (canReturn) SetControlValue('tdVal', value);
            }
        }
    }
}

function AddColumns(ID, ARRAY) {
    var table = document.getElementById(ID);
    var header = table.createTHead();
    var row = header.insertRow(0);
    table.appendChild(row);

    for (var i = 0; i < ARRAY.length; i++) {
        var cell = document.createElement("th");
        row.appendChild(cell);
        cell.innerHTML = ARRAY[i];
    }
}


function AddRow(ID, ARRAY) {
    var table = document.getElementById(ID);//.getElementsByTagName('tbody')[0];
    // var newRow = tableRef.insertRow();

    var tableLength = table.length;
    var newRow = table.insertRow(tableLength);

    for (var i = 0; i < ARRAY.length; i++) {
        cell1 = newRow.insertCell(i);
        cell1.innerHTML = ARRAY[i];
    }
}

function UpdateRow(ID, ROWID, CELLID, VALUE) {
    var table = document.getElementById(ID);

    if (table.rows[ROWID + 1].cells[CELLID].innerHTML !== VALUE) {
        table.rows[ROWID + 1].cells[CELLID].innerHTML = VALUE;
    }
}

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}


function CompareRow(ID, ROWID, ARRAY) {
    var table = document.getElementById(ID);

    for (var i = 0; i < ARRAY.length; i++) {

        if (table.rows[ROWID + 1].cells[i].innerHTML !== ARRAY[i]) return false;
    }
    return true;
}


function ColorRow(ID, INDEX, COLOR) {
    var table = document.getElementById(ID);
    var rows = table.getElementsByTagName("tr");
    rows[INDEX].style.backgroundColor = COLOR;
}


function autocomplete(inp, arr) {
    var currentFocus;

    inp.addEventListener("input", function () {
        var a, b, i, val = this.value;
        closeAllLists();
        if (!val) { return false; }
        currentFocus = -1;
        /*create a DIV element that will contain the items (values):*/
        a = document.createElement("DIV");
        a.setAttribute("id", this.id + "autocomplete-list");
        a.setAttribute("class", "autocomplete-items");
        a.style.position = "absolute";
        a.style.backgroundColor = "white";
        a.style.cursor = "pointer";
        /*append the DIV element as a child of the autocomplete container:*/
        this.parentNode.appendChild(a);
        /*for each item in the array...*/
        for (i = 0; i < arr.length; i++) {
            if (arr[i].substr(0, val.length).toUpperCase() === val.toUpperCase()) {
                b = document.createElement("DIV");
                b.innerHTML = "<strong>" + arr[i].substr(0, val.length) + "</strong>";
                b.innerHTML += arr[i].substr(val.length);
                b.innerHTML += "<input type='hidden' value='" + arr[i] + "'>";
                b.addEventListener("click", function () {
                    /*insert the value for the autocomplete text field:*/
                    inp.value = this.getElementsByTagName("input")[0].value;
                    /*close the list of autocompleted values,
                    (or any other open lists of autocompleted values:*/
                    closeAllLists();
                });
                a.appendChild(b);
            }
        }
    });
    /*execute a function presses a key on the keyboard:*/
    inp.addEventListener("keydown", function (e) {
        var x = document.getElementById(this.id + "autocomplete-list");
        if (x) x = x.getElementsByTagName("div");
        if (e.keyCode === 40) {
            /*If the arrow DOWN key is pressed,
            increase the currentFocus variable:*/
            currentFocus++;
            /*and and make the current item more visible:*/
            addActive(x);
        } else if (e.keyCode === 38) { //up
            /*If the arrow UP key is pressed,
            decrease the currentFocus variable:*/
            currentFocus--;
            /*and and make the current item more visible:*/
            addActive(x);
        } else if (e.keyCode === 13) {
            /*If the ENTER key is pressed, prevent the form from being submitted,*/
            e.preventDefault();
            if (currentFocus > -1) {
                /*and simulate a click on the "active" item:*/
                if (x) x[currentFocus].click();
            }
        }
    });
    function addActive(x) {
        /*a function to classify an item as "active":*/
        if (!x) return false;
        /*start by removing the "active" class on all items:*/
        removeActive(x);
        if (currentFocus >= x.length) currentFocus = 0;
        if (currentFocus < 0) currentFocus = (x.length - 1);
        /*add class "autocomplete-active":*/
        x[currentFocus].classList.add("autocomplete-active");
    }
    function removeActive(x) {
        /*a function to remove the "active" class from all autocomplete items:*/
        for (var i = 0; i < x.length; i++) {
            x[i].classList.remove("autocomplete-active");
        }
    }
    function closeAllLists(elmnt) {
        /*close all autocomplete lists in the document,
        except the one passed as an argument:*/
        var x = document.getElementsByClassName("autocomplete-items");
        for (var i = 0; i < x.length; i++) {
            if (elmnt !== x[i] && elmnt !== inp) {
                x[i].parentNode.removeChild(x[i]);
            }
        }
    }
    /*execute a function when someone clicks in the document:*/
    document.addEventListener("click", function (e) {
        closeAllLists(e.target);
    });
}

function CopyCells(ID, ID2) {
    var element = document.getElementById(ID);
    if (element !== null && element !== undefined) {
        cells = element.getElementsByTagName('td');
        for (var i = 0, len = cells.length; i < len; i++) {

            cells[i].onclick = function () {
                var value = this.textContent;

                var canReturn = value !== null && value !== undefined;

                if (canReturn) {
                    var tempField = document.createElement("textarea");

                    document.body.appendChild(tempField);
                    tempField.value = value;
                    tempField.select();
                    document.execCommand("copy");
                    document.body.removeChild(tempField);
                    SetControlValue(ID2, "Cell value was copied");
                }
            }
        }
    }
}

function Focus(ID) {
    document.getElementById(ID).focus();
}//Use: "Focus('TB1')"

function Show(ID, VISIBLE) {
    var control = document.getElementById(ID);
    control.style.display = VISIBLE;
}//Use: Show('TB1','initial') | Show('TB1','none')

function Refresh(ID) {
    var style = document.styleSheets[0];
    style.removeRule(0);

    var control = document.getElementById(ID);
    control.refresh();
}

function CopyText(ID) {
    var copyText = document.getElementById(ID);
    copyText.select();
    copyText.setSelectionRange(0, 99999);
    document.execCommand("copy");
}

function GlobalValue(element) {
    return element.value;
}

function ElementFocus(element) {
    element.focus();
}

function GlobalCopy(element) {
    element.select();
    element.setSelectionRange(0, 99999);
    document.execCommand("copy");
}

function CopyGlobal(ID) {
    var copyText = document.getElementById(ID);
    copyText.select();
    copyText.setSelectionRange(0, 99999);
    document.execCommand("copy");
}

function Draw(ID, X1, Y1, X2, Y2) {
    var c = document.getElementById(ID);
    var ctx = c.getContext("2d");
    ctx.beginPath();
    ctx.moveTo(X1, Y1);
    ctx.lineTo(X2, Y2);
    ctx.stroke();
}