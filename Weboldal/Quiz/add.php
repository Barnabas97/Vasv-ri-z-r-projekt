<?php include "database.php"; ?>

<?php 
if (isset($_POST['submit'])){
  
   $question_number = $_POST['question_number'];      
   $question_text = $_POST['question_text'];
   $correct_choice = $_POST['correct_choice'];
   $choices = array();
   $choices[1] = $_POST['choice1'];
   $choices[2] = $_POST['choice2'];
   $choices[3] = $_POST['choice3'];
   $choices[4] = $_POST['choice4'];
   $choices[5] = $_POST['choice5'];

   
   $query="insert into kerdesek (kerdesszam, akerdes) 
   	 values('$question_number','$question_text')";
   $insert_row=$mysqli->query($query) or die ($mysqli->error.__LINE__);

   
   if($insert_row){
      foreach($choices as $choice => $value){
        if($value != ''){
	       if($correct_choice == $choice){
	          $is_correct = 1;
	       } else {
	         $is_correct = 0;
	       }
              $query="insert into valaszok (kerdesszam,jovalasz,valasz) 
   	          values('$question_number','$is_correct','$value')";
              $insert_row=$mysqli->query($query) or die ($mysqli->error.__LINE__);
	          if($insert_row){
	            continue;
	          }else {
	      		die("Error: (".$mysqli->errno.") ".$mysqli->eerror);
	    	}
        }
    }
   $msg="Question has been added";
}
}

$query = "select * from kerdesek";
$questions = $mysqli->query($query) or die ($mysqli->error.__LINE__);
$total=$questions->num_rows;
$next=$total+1;
?>

<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8" />
    <title>Csillagász quiz!</title>
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
	     <h2>Adj hozzá egy kérdést</h2>
	     <?php 
	     	   if(isset($msg)) {
	     	      echo "<p>".$msg."</p>";
	     }
	     ?>
	     <form method="post" action="add.php">
	     	   <p>
			<label>Kérdésszám</label>
			<input type="number" value="<?php echo $next; ?>" name="question_number" />
		   </p>
	     	   <p>
			<label>Kérdés</label>
			<input type="text" name="question_text" />
		   </p>
	     	   <p>
			<label>Válasz #1: </label>
			<input type="text" name="choice1" />
		   </p>
	     	   <p>
			<label>Válasz #2: </label>
			<input type="text" name="choice2" />
		   </p>
	     	   <p>
			<label>Válasz #3: </label>
			<input type="text" name="choice3" />
		   </p>
	     	   <p>
			<label>Válasz #4: </label>
			<input type="text" name="choice4" />
		   </p>
	     	   <p>
			<label>Válasz #5: </label>
			<input type="text" name="choice5" />
		   </p>
	     	   <p>
			<label>A jó válasz </label>
			<input type="number" name="correct_choice" />
		   </p>
		   <p>
			<input type="submit" name="submit" value="Kész" />
		   </p>
	     </form>
	</div>
      </main>


    <footer>
      <div class="container">
      	   
      </div>
    </footer>
  </body>
</html>