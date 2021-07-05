<?php include "database.php"; ?>
<?php session_start(); ?>
<?php
	
	

 ?>
<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8" />
    <title>PHP Quizzer!</title>
    <link rel="stylesheet" href="style.css" type="text/css" />
  </head>
  <body>
    <div id="container">
      <header>
        <div class="container">
          <h1>Csillagász quiz</h1>
	</div>
      </header>


      <main>
	<div class="container">
	     <h2>Készen vagy!</h2>
	     <p>Ügyes vagy! Végetértél a teszttel!</p>
	     <p>Végső eredményed!: <?php echo $_SESSION['score']; ?></p>
	     <a href="question.php?n=1" class="start">Teszt újbóli kitöltése!</a>
	     <?php session_destroy(); ?>
	</div>
      </main>


    <footer>
      <div class="container">
      	   Készen vagy! :)
      </div>
    </footer>
  </body>
</html>