var map;
var directionsService;
var directionDisplay;

// Données
var contentString = '<div id="content">' +
    '<div id="siteNotice">' +
    '</div>' +
    '<h1 id="firstHeading" class="firstHeading">Le FBI</h1>' +
    '<div id="bodyContent">' +
    '<p><b>Le FBI</b>, bar et frites à gogo ! ' +
    '<div><img src="../fbiBan.jpg"><img></div>' +
    '<div><a href="/editbar">Editer le bar</a> ' +
    '</div>'
    +
    '</div>';

// InfoWindow
var infowindow = new google.maps.InfoWindow({
    content: contentString
});

// Check Geoloc before callMap
function CheckGeoloc(location) {
    if (navigator.geolocation) {
        return "ok";
    } else {
        return "nok";
    }
}


function callMap(location) {

    navigator.geolocation.getCurrentPosition(function (pos) {
        var LatLong = pos.coords.latitude + " | " + pos.coords.longitude;
        console.log(LatLong);

        map = new google.maps.Map(document.getElementById('map'), {

            zoom: 15,
            enableHighAccuracy: true,
            center: { lat: Number(pos.coords.latitude), lng: Number(pos.coords.longitude) },
            mapTypeControl: false,
            disableDefaultUI: true,
            styles: [
                {
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#ebe3cd"
                        }
                    ]
                },
                {
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "color": "#523735"
                        }
                    ]
                },
                {
                    "elementType": "labels.text.stroke",
                    "stylers": [
                        {
                            "color": "#f5f1e6"
                        }
                    ]
                },
                {
                    "featureType": "administrative",
                    "elementType": "geometry.stroke",
                    "stylers": [
                        {
                            "color": "#c9b2a6"
                        }
                    ]
                },
                {
                    "featureType": "administrative.land_parcel",
                    "elementType": "geometry.stroke",
                    "stylers": [
                        {
                            "color": "#dcd2be"
                        }
                    ]
                },
                {
                    "featureType": "administrative.land_parcel",
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "color": "#ae9e90"
                        }
                    ]
                },
                {
                    "featureType": "landscape.natural",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#dfd2ae"
                        }
                    ]
                },
                {
                    "featureType": "poi",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#dfd2ae"
                        }
                    ]
                },
                {
                    "featureType": "poi",
                    "elementType": "labels.text",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "poi",
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "color": "#93817c"
                        }
                    ]
                },
                {
                    "featureType": "poi.business",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "poi.park",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#a5b076"
                        }
                    ]
                },
                {
                    "featureType": "poi.park",
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "color": "#447530"
                        }
                    ]
                },
                {
                    "featureType": "road",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#f5f1e6"
                        }
                    ]
                },
                {
                    "featureType": "road",
                    "elementType": "labels.icon",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "road.arterial",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#fdfcf8"
                        }
                    ]
                },
                {
                    "featureType": "road.highway",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#f8c967"
                        }
                    ]
                },
                {
                    "featureType": "road.highway",
                    "elementType": "geometry.stroke",
                    "stylers": [
                        {
                            "color": "#e9bc62"
                        }
                    ]
                },
                {
                    "featureType": "road.highway.controlled_access",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#e98d58"
                        }
                    ]
                },
                {
                    "featureType": "road.highway.controlled_access",
                    "elementType": "geometry.stroke",
                    "stylers": [
                        {
                            "color": "#db8555"
                        }
                    ]
                },
                {
                    "featureType": "road.local",
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "color": "#806b63"
                        }
                    ]
                },
                {
                    "featureType": "transit",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "transit.line",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#dfd2ae"
                        }
                    ]
                },
                {
                    "featureType": "transit.line",
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "color": "#8f7d77"
                        }
                    ]
                },
                {
                    "featureType": "transit.line",
                    "elementType": "labels.text.stroke",
                    "stylers": [
                        {
                            "color": "#ebe3cd"
                        }
                    ]
                },
                {
                    "featureType": "transit.station",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#dfd2ae"
                        }
                    ]
                },
                {
                    "featureType": "water",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#b9d3c2"
                        }
                    ]
                },
                {
                    "featureType": "water",
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "color": "#92998d"
                        }
                    ]
                }
            ]

        }); 

        // Place Marker on initial position
        var markerPos = new google.maps.Marker({
            position: {
                lat: Number(pos.coords.latitude),
                lng: Number(pos.coords.longitude)
            },
            map: map,
            title: 'Click pour zoomer'
        });


        // SetPosition Marker
        navigator.geolocation.watchPosition(function (pos) {
            markerPos.setPosition({ lat: Number(pos.coords.latitude), lng: Number(pos.coords.longitude) });
        });



        // PlaceMarker on click
        google.maps.event.addListener(map, 'click', function (event) {
            placeMarker(event.latLng);
        });

     
//var request = new XMLHttpRequest()

//request.open('GET', 'https://barfinder.azurewebsites.net/api/bar', true)
//request.onload = function () {
//    // Begin accessing JSON data here
//    var data = JSON.parse(this.response)

//    if (request.status >= 200 && request.status < 400) {
//        data.forEach(bar => {
//            bar[i] = new google.maps.Marker({
//                position: {
//                    lat: Number(bars.lat),
//                    lng: Number(bars.lng)
//                },
//                map: map,
//                title: bars.nonBar,
//            });
//        })
//    } else {
//        console.log('error')
//    }
//}

//request.send()
//execute blazor function
// locationRef.invokeMethod('GetLocationEvent', LatLong);

    });

}

function placeMarker(location) {
        var marker = new google.maps.Marker({
        position: location,
        map: map,
        icon: new google.maps.MarkerImage('../iconMarker.png')
    });
    marker.addListener('click', function () {
        infowindow.open(map, marker);
        document.getElementById("steps").style.display = 'block';
        directionService(location, marker.getPosition())
    });
    return marker;
}

function setElementTextById(id, text) {
    document.getElementById(id).innerText = text;
}

function displayRoute(origin, destination, service, display) {
    service.route({
        origin: origin,
        destination: destination,
        travelMode: google.maps.TravelMode.DRIVING,
        avoidTolls: true
    }, function (response, status) {
        if (status === google.maps.DirectionsStatus.OK) {
            display.setDirections(response);
        } else {
            alert('Could not display directions due to: ' + status);
        }
    });
}

function computeTotalDistance(result) {
    var total = 0;
    var myroute = result.routes[0];
    for (var i = 0; i < myroute.legs.length; i++) {
        total += myroute.legs[i].distance.value;
    }
    total = total / 1000;
    //document.getElementById('total').innerHTML = total + ' km';
}

function directionService(location, destination) {
    navigator.geolocation.getCurrentPosition(function (pos) {
        directionsService = new google.maps.DirectionsService;
        directionsDisplay = new google.maps.DirectionsRenderer({
            draggable: true,
            map: map,
            panel: document.getElementById("steps")
        });

        directionsDisplay.addListener('directions_changed', function () {
            computeTotalDistance(directionsDisplay.getDirections());
        });

        displayRoute({ lat: Number(pos.coords.latitude), lng: Number(pos.coords.longitude)}, destination, directionsService,
            directionsDisplay);
    });
}