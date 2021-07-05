<?php include "database.php"; ?>
<?php session_start(); ?>
<?php
	
	$number = (int) $_GET['n'];

	
	$query = "select * from kerdesek";
	$results = $mysqli->query($query) or die($mysqli->error.__LINE__);
	$total=$results->num_rows;

	
	$query = "select * from `kerdesek` where kerdesszam = $number";

	
	$result = $mysqli->query($query) or die($mysqli->error.__LINE__);
	$question = $result->fetch_assoc();


	
	$query = "select * from `valaszok` where kerdesszam = $number";

	
	$choices = $mysqli->query($query) or die($mysqli->error.__LINE__);

 ?>
<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8" />
    <title>Csillagász quiz</title>
    <link rel="stylesheet" href="style.css" type="text/css" />
  </head>
  <body>
    <div id="container">
      <header>
        <div class="container">
          <h1>Csillagász quiz 󠀠󠀠󠀠󠀠󠀠󠀠🌌</h1>
	</div>
      </header>


      <main>
      <div class="container">
        <div class="current">Kérdés <?php echo $number; ?> a <?php echo $total; ?>-ból</div>
	<p class="question">
	   <?php echo $question['akerdes'] ?>
	</p>
	<form method="post" action="process.php">
	      <ul class="choices">
	        <?php while($row=$choices->fetch_assoc()): ?>
		<li><input name="choice" type="radio" value="<?php echo $row['id']; ?>" />
		  <?php echo $row['valasz']; ?>
		</li>
		<?php endwhile; ?>
	      </ul>
	      <input type="submit" value="Válasz" />
	      <input type="hidden" name="number" value="<?php echo $number; ?>" />
	</form>
      </div>
    </div>
    </main>


    <footer>
      <div class="container">
      	   
      </div>
    </footer>
  </body>
</html>