"use strict";
(function () {
    angular.module("myApp")
           .factory("clientService", ["$http", function ($http) {

               var getClients = function () {
                   return $http.get('/api/clients')
                               .then(function (response) {
                                   return response.data;
                               });
               };

               var getClientDropDowns = function (clientId) {
                   return $http.get('/api/clients/' + clientId + '/dropdowns')
                               .then(function (response) {
                                   return response.data;
                               });
               };

               return {
                   getClients: getClients,
                   getClientDropDowns: getClientDropDowns
               };
               
           }]);
})();