<?php
header("Location: listado_usuarios.php");
require_once "includes/conexion.php";
$cadena = "DELETE FROM usuarios WHERE id=$_GET[id]";
$resultado = MySqli_query($conexion,$cadena);

if ($resultado) {
	echo "baja exitosa" . "<br>";
} else {
	echo "baja fallida" . "<br>";
}
?>