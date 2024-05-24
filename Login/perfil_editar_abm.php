<?php

require_once "includes/conexion.php";

if (isset($_POST['id'])) {
     $id = $_POST['id'];
     $nombre_completo = $_POST['nom'];
     $correo = $_POST['cor'];
     $usuario = $_POST['usu'];
     $consulta = "UPDATE usuarios SET nombre_completo='$nombre_completo', correo='$correo', usuario='$usuario' WHERE id=$id";
     $run = mysqli_query($conexion, $consulta);
     if ($run) {
          header('location:listado_usuarios.php');
     } else {
          echo "Error: " . mysqli_error($conexion);
     }
}
?>