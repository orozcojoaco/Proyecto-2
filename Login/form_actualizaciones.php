
<?php require_once "includes/conexion.php";

           

?>

<style>
	.caja_produc {
		display: flex;
		justify-content: center;
		align-items: center;
	}
</style>

<!DOCTYPE html>
<html lang="en">

<head>
	<?php require_once "includes/header.php"; ?>
	<?php require_once "includes/style-listado-usuarios.php"; ?>
</head>

	<body>
		
		<header>
			
		</header>

		<main>
		<h3>formulario de modificacion de productos</h3>
			<div class="caja_produc">
				
				<form action="actualizar_producto.php" method="POST">

				CAMPO CLAVE:<br>
				Nombre de Producto: <input type="text" name="nom_clave" required><br><br>


				CAMPOS A ACTUALIZAR:<br>
				Nombre de Producto: <input type="text" name="nom_prod" required><br>
				tipo de publicacion del Producto: <select name="catego" id="">
					<option value="indumentaria">indumentaria</option>
					<option value="muebles">muebles</option>
					<option value="electrodomesticos">electrodomesticos</option>
					<option value="juguetes">juguetes</option>
					<option value="comida pa animales"comida pa animales>comida pa animales</option>
					<option value="otro">otro</option>
				</select>
				Info del Producto: <input type="text" name="inf_prod" required><br>
				Foto del Producto: <input type="file" name="ft_prod" required><br>

				<input type="submit" value="Actualizar"><br>

			</form>
		</div>
		<br><br>
		<center>
			<button class="btnlogin"><a href="formu-general.php">Volver</a></button>
		</center>
	</main>

	<footer class="py-5">
		<?php require_once "includes/footer.php"; ?>
	</footer>

</body>

</html>