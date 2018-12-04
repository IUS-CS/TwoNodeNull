
var base = "https://sandbox-api.brewerydb.com/v2/"

//var type = "%26type%3dbeer";
//var key = "%26key%3dd9e3c76540e2267dd4f9e09ede879957";
//var route = "?route=%2fv2%2fsearch%3fq%3d";

document.addEventListener('DOMContentLoaded', bind); //DOM must load first before binding buttons.

function bind(){
    var el = document.getElementById('beerSub');
    el.addEventListener('click', function(event){
        var beerName = document.getElementById('br').value;
        var bts = beerName.split(' ').join('_');
        var type = "&type=beer";
        var key = "&key=121ba824afa18545446f7538c1dad3b4";
        var search = "/search?q=";
        var fullUrl = base + search + bts + type + key; //construct a custom url based on the user's input
        var req = new XMLHttpRequest(); //create the request with the new url
        req.open("GET", fullUrl, true);
        //req.setRequestHeader("Access-Control-Allow-Origin", "*");
        //req.setRequestHeader('Access-Control-Allow-Methods', 'GET');
        req.send(null);
        req.addEventListener('load', function(){
           //console.log("Request Recieved" + req.responseText);
            var response = JSON.parse(req.responseText); //parse the response text
            document.getElementById("sb").textContent = response.data[0].name;
            document.getElementById("beerImg").src = response.data[0].labels.medium;
            document.getElementById("id").textContent = response.data[0].id;
            document.getElementById("abv").textContent = response.data[0].abv;
            document.getElementById("bt").textContent = response.data[0].style.category.name;
            document.getElementById("try1").textContent = response.data[1].name;
            document.getElementById("try2").textContent = response.data[2].name;
            var beer = /beer/;
            var brew = "?withBreweries=y"
            var id = response.data[0].id;
            var newUrl = base + beer + id + brew + key
            var req2 = new XMLHttpRequest();
            req2.open("GET", newUrl, true);
            req2.send(null);
            req2.addEventListener('load', function(){
                var response2 = JSON.parse(req2.responseText); //parse the response tex
                console.log(response2);
                document.getElementById("brew").textContent = response2.data.breweries[0].name; 
                var street = response2.data.breweries[0].locations[0].streetAddress;
                var city = response2.data.breweries[0].locations[0].locality;
                var state = response2.data.breweries[0].locations[0].region;
                var zip = response2.data.breweries[0].locations[0].postalCode;
                var fullAddr = street + ', ' + city + ', ' + state + ' ' + zip;
                document.getElementById("loc").textContent = fullAddr;
                document.getElementById("brewImg").src = response2.data.breweries[0].images.medium; 
            
        });
            
        });
       
        //console.log(JSON.parse(req.responseText));
        event.preventDefault();
    });
}