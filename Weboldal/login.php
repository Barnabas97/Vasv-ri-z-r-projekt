<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie-edge">
    <title>Future.hu</title>
 <script src="Imports/bootstrap-4.3.1-dist/jquery-3.3.1.min.js"></script>
	<script src="Imports/bootstrap-4.3.1-dist/js/bootstrap.bundle.min.js"></script>
	<script src="Imports/bootstrap-4.3.1-dist/js/bootstrap.min.js"></script>
	
	
  

	<link rel="stylesheet" type="text/css" href="Imports/bootstrap-4.3.1-dist/css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="Imports/bootstrap-4.3.1-dist/css/bootstrap-grid.css">
	
	<link rel="stylesheet" type="text/css" href="Imports/bootstrap-4.3.1-dist/css/bootstrap-reboot.css">
	
	<link rel="stylesheet" type="text/css" href="register.css">
	

  
  



</head>
<body>
  <div class="regisztrációsform">
    <form  id="regisztrálás" name="regisztrálás">
      <input type="text" name="user" id="user" placeholder="Írd be a felhasználóneved" maxlength="50" required ><br>
      <span class="error" id="userErr"></span>
	  <br>

    
      <input type="password" name="pwd" id="password" placeholder="Írd be a jelszavad" maxlength="50" required><br>
      <span class="error" id="jelszoErr"></span>
	  <br>
 

        <input id="kuldes" type="button" onclick="kuld()" class="btn" name="registerbutton" value="Bejelentkezés">





</form>

</body>
</html>

<script>
function kuld(){
	
  $.post("bejelentkezes.php",
  {
    user: document.getElementById("user").value,
	
    pwd: document.getElementById("password").value
	
	
  },
  function(data){
	  console.log(data);
    if(data != ""){
	window.location.replace("menü.html");
		
		
	}
	else{
		alert("A felhasználónév vagy jelszó nem megfelelő!");
	}
  });
}

</script>
