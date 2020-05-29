/// <reference path="../Views/Home/Zamekironfirst.cshtml" />
//document.body.addEventListener(myFunction2);
var numerPlanszy = 1

document.body.addEventListener('keyup', myFunction);
function myFunction2() {
    var x = document.getElementById("fname");
    t = parseInt(x.style.top, 10) || 0
    left = parseInt(x.style.left, 10) || 0
    // alert(" " + t + " " + left);

    if (left >= 205 && left <= 240 && t <= 370 && t >= 300) {
        if (confirm("Czy chcesz wejsc do zamku Casle Ironfirs?")) {
 
            window.location.href = "/Home/Walka";
            /*square1.className = "square2"
            fname2.style.display = "none"
            plansza1.src = "../../Images/wnetrzezamku1.png"
            plansza1.style.left = 0 + "px";
            plansza1.style.top = 0 + "px";
            fname.style.left = 161 + "px";
            fname.style.top = 463 + "px"; */
        }
    }
}




var timer = setInterval(internal, 1000);


function internal() {

    var x = document.getElementById("fname2");

    num = parseInt(x.style.left, 10) || 0;
    num2 = parseInt(x.style.top, 10) || 0;


    if (parseInt(fname.style.left) < parseInt(x.style.left)) {
        num -= 5;
        x.style.left = num + "px";
    }

    else if (parseInt(fname.style.left) > parseInt(x.style.left)) {
        num += 5;
        x.style.left = num + "px";
    }
    else if (parseInt(fname.style.top) > parseInt(x.style.top)) {
        num2 += 5;
        x.style.top = num2 + "px";
    }
    else if (parseInt(fname.style.top) < parseInt(x.style.top)) {
        num2 -= 5;
        x.style.top = num2 + "px";
    }


    if (x.style.display === "block" && parseInt(fname.style.top) >= (parseInt(x.style.top) - 30) && parseInt(fname.style.top) <= (parseInt(x.style.top) + 30)
        && parseInt(fname.style.left) >= (parseInt(x.style.left) - 30) && parseInt(fname.style.left) <= (parseInt(x.style.left) + 30)
        ) {

        window.location.href = "/Home/Walka";
        // alert("Hello! I am an alert box!!");
        // var url = Url.Action("Home", "Walka"); //,  "http://localhost/home/walka";
        // $(location).attr('href', url);

    }

    Text3.value = x.style.top;
    Text4.value = fname.style.top;
    Text5.value = document.getElementById("fname2").style.display === "block" //parseInt(x.style.top) + 5  +"px";
    Text6.value = (fname.style.top) >= (parseInt(x.style.top) - 30)

    /*if (distance < 0) {
        clearInterval(x);
        document.getElementById("demo").innerHTML = "EXPIRED";
    }*/
}


function pause() {
    if (buttonPause.textContent == "Pause") {
        clearInterval(timer);
        buttonPause.textContent = "Start"
    }
    else if (buttonPause.textContent == "Start") {
        timer = setInterval(internal, 1000);
        buttonPause.textContent = "Pause"
    }

}

function myFunction(e) {
    var x = document.getElementById("fname");
    /* var i;
     i = x.style.left;
     i += 2;*/
    if (e.keyCode == 37) {
        // alert("Hello! I am an alert box!!");
        //  x.style.left = i + "px";
        // x.value = x.value.toUpperCase();
        num = parseInt(x.style.left, 10) || 0;
        num -= 5;
        x.style.left = num + "px";
        x.value = e.keyCode;
    }
    if (e.keyCode == 39) {
        // x.style.left = i + "px";
        //x.value = x.value.toUpperCase();
        num = parseInt(x.style.left, 10) || 0;
        num += 5;
        x.style.left = num + "px";
        x.value = e.keyCode;
    }
    if (e.keyCode == 38) {
        // x.style.left = i + "px";
        //x.value = x.value.toUpperCase();
        num = parseInt(x.style.top, 10) || 0;
        num -= 5;
        x.style.top = num + "px";
        x.value = e.keyCode;
    }

    if (e.keyCode == 40) {
        // x.style.left = i + "px";
        //   x.value = x.value.toUpperCase();
        num = parseInt(x.style.top, 10) || 0;
        num += 5;
        x.style.top = num + "px";
        x.value = e.keyCode;
    }
    if (numerPlanszy == 1)
        myFunction2();
    Text1.value = x.style.top;
    Text2.value = x.style.left;
}