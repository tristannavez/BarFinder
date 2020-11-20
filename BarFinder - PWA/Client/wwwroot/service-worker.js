// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
console.log("This is service worker talking..");

var cacheName = 'blazor-pwa-sample';
var filesToCache = [
    '/',
    //html and css files
    '/index.html',
    '/css/site.css',
    '/css/bootstrap/bootstrap.min.css',
    '/css/open-iconic/font/css/open-iconic-bootstrap.min.css',
    '/open-iconic',
    '/css/open-iconic/font/fonts/open-iconic.woff',
    '/css/loading.css',
    //blazor framework
    '/manifest.json',
    '/serviceworker.js',
    //the web assembly/.net dll's
    '/_framework/wasm/mono.js',
    '/_framework/wasm/mono.wasm',
    '/_framework/_bin/Microsoft.AspNetCore.Blazor.Browser.dll',
    '/_framework/_bin/Microsoft.AspNetCore.Blazor.dll',
    '/_framework/_bin/Microsoft.Extensions.DependencyInjection.Abstractions.dll',
    '/_framework/_bin/Microsoft.Extensions.DependencyInjection.dll',
    '_framework/_bin/Microsoft.JSInterop.dll',
    '/_framework/_bin/mscorlib.dll',
    '/_framework/_bin/System.Net.Http.dll',
    '/_framework/_bin/Mono.WebAssembly.Interop.dll',
    '/_framework/_bin/System.dll',
    '/_framework/_bin/System.Core.dll',
    //The compiled project .dll's
    '/_framework/_bin/POIN.Client.dll'
];


self.addEventListener('install', (e) => {
    console.log('[Service Worker] Installation');
    self.skipWaiting();
    e.waitUntil(
        caches.open(cacheName).then(function (cache) {
            return cache.addAll(filesToCache);
        })
    );
});

self.addEventListener('activate', event => {
    event.waitUntil(self.clients.claim());
});

self.addEventListener('fetch', event => {
    event.respondWith(
        caches.match(event.request, { ignoreSearch: true }).then(response => {
            return response || fetch(event.request);
        })
    );
});