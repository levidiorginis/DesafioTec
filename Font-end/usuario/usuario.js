angular
  .module("usuarioApp", [])
  .controller("usuarioController", function ($scope, $http) {
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

    $http
      .get("https://localhost:7287/api/user", {
        headers: {
          Authorization: "Bearer " + token,
        },
      })
      .then(function (response) {
        $scope.usuarios = response.data;
      })
      .catch(function (error) {
        console.log("Erro ao carregar lista de usuários", error);
      });

    $scope.abrirFormulario = function () {
      // Define a rota para o formulário de cadastro
      window.location.pathname = "usuario/formulario/formulario.html";
    };

    $scope.excluirUsuario = function (usuario) {
      console.log("teste")
      $http
        .delete("https://localhost:7287/api/user/" + usuario.id, {
          headers: {
            Authorization: "Bearer " + token,
          },
        })
        .then(function (response) {
          $scope.usuarios = response.data;
        })
        .catch(function (error) {
          console.log("Erro ao carregar lista de usuários", error);
        });
    };
  });
