<?php
   session_start();
   
   $db=mysqli_connect("localhost", "root", "", "zarodolgozat_2018judbar");

   if(isset($_POST['user'])) {
     $username = $_POST['user'];
		$password = $_POST['pwd'];
        

		$sql = "SELECT jelszo FROM felhasznalo WHERE felhasznalonev='".$username."'";
				$result=$db->query($sql);
				
			
          
		 while($row = $result->fetch_assoc()) {
			 if($row['jelszo']==$password)
			 {
				 $_SESSION['name']=$username;
				 echo $username;
			 }
		 
		 
		 }
   }

?>