<?php
   
   $db=mysqli_connect("localhost", "root", "", "zarodolgozat_2018judbar");

   if(isset($_POST['user'])) {
     $username = $_POST['user'];
      $email = $_POST['email'];
       $password = $_POST['pwd'];
        $password2 = $_POST['pwd2'];


          if($password == $password2)
		  {
			  
				
				$sql = "INSERT INTO felhasznalo(felhasznalonev,	email,	jelszo) VALUES ('$username', '$email', '$password')";
				$db->query($sql);
				$_SESSION['message'] =  "Sikeres belépés!";
				$_SESSION['felhasznalonev'] = $username;
				//header("location: index.html");
				echo "Siker";


          }
		  else{
            $_SESSION['message'] = "A két jelszó nem egyezik meg!";
			
          }
		  

   }

?>