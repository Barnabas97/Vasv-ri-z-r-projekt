<?php include "database.php"; ?>

<?php
	
	$query="select * from kerdesek";
	
	$results = $mysqli->query($query) or die ($mysqli->error.__LINE__);
	$total = $results->num_rows;

 ?>
<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8" />
    <title>Csillagász quiz</title>
    <link rel="stylesheet" type="text/css"  href="style.css"/>
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
        <h2>Teszteld le a weboldalon megszerzett tudásod!</h2>
	<p>Válaszolj meg minél több kérdést megfelelően!</p>
	<ul>
		<li><strong>Kérdések száma </strong><?php echo $total; ?></ul>
		<li><strong>Típus </strong>Többféle válaszlehetőseg</ul>
		<li><strong>Kb. igénybevett idő a teszthez </strong><?php echo $total*0.5; ?> perc</ul>
	</ul>
	<a href="question.php?n=1" class="start">Teszt kitöltése</a>
      </div>
    </div>
    </main>


    <footer>
      <div class="container">
      	   
      </div>
    </footer>
  </body>
</html>