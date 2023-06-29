angular
  .module("formularioApp", [])
  .controller("formularioController", function ($scope, $http) {
    function getCookieValue(cookieName) {
      var cookieValue = "";
      var cookies = document.cookie.split(";");

      for (var i = 0; i < cookies.length; i++) {
        var cookie = cookies[i].trim();

        if (cookie.indexOf(cookieName + "=") === 0) {
          cookieValue = cookie.substring(cookieName.length + 1);
          break;
        }
      }

      return cookieValue;
    }

    var token = getCookieValue("token");

    $scope.salvarUsuario = function () {
      $http
        .post("https://localhost:7287/api/user", $scope.usuario, {
          headers: {
            Authorization: "Bearer " + token,
          },
        })
        .then(function (response) {
          console.log("Usuário salvo com sucesso");
          // Redireciona de volta para a página de usuários
          window.location.pathname = "usuario/usuario.html";
        })
        .catch(function (error) {
          console.error("Erro ao salvar usuário", error);
        });
    };
  });
