<?php

session_start();

require_once "../conexion.php";

$correo = $_POST['correo'];
$contrasena = $_POST['contrasena'];

$validar_login = mysqli_query($conexion, "SELECT * FROM usuarios WHERE correo = '$correo' and contrasena = MD5('$contrasena')");

if (mysqli_num_rows($validar_login) > 0) {
    $_SESSION = mysqli_fetch_assoc($validar_login);
    header("location: ../../Pagina-empresa/indexlog.php");
    exit();
} else {
    echo '
        <script>
            alert("Este usuario no existe, registrate");
            window.location = "index.php";
        </script>
    ';
    exit();
}
