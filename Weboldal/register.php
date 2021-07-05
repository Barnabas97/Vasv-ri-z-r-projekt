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
	

  <script src="register.js"></script>



</head>
<body>
  <div class="regisztrációsform">
    <form  id="regisztrálás" name="regisztrálás">
      <input type="text" name="user" id="user" placeholder="Írd be a felhasználóneved" maxlength="50" required ><br>
      <span class="error" id="userErr"></span>
	  <br>

      <input type="email" name="email" id="email" placeholder="Írd be az e-mail címed"><br>
      <span class="error" id="EmailErr"></span>
      <br>
      <input type="password" name="pwd" id="password" placeholder="Írd be a jelszavad" maxlength="50" required><br>
      <span class="error" id="jelszoErr"></span>
	  <br>
  <input type="password" name="pwd2" id="password2" placeholder="Írd be a jelszavad mégegyszer" maxlength="50" required><br>
  <br>

    <div id="Radibuttonok">
    <input type="radio" name="nem" id="radio"><span id="but">Férfi</span><input type="radio" name="nem" id="radio"><span id="but">Nő</span><br>
      <br>
      <span class="error" id="RadioErr"></span>
    </div>



        <input type="text" name="elsonev" id="button" placeholder="Születési év"><br>
        <br>
        <select id="hónap"><option>Január</option><option>Február</option><option>Március</option><option>Április</option><option>Május</option>
          <option>Június</option><option>Július</option><option>Augusztus</option><option>Szeptember</option><option>Október</option><option>November</option><option>December</option>
        </select>
        <select id="nap"><option>1</option><option>2</option><option>3</option><option>4</option><option>5</option>
          <option>6</option><option>7</option><option>8</option><option>9</option><option>10</option><option>11</option><option>12</option>
            <option>13</option>
              <option>14</option>
                <option>15</option>
                  <option>16</option>
                    <option>17</option>
                      <option>18</option>
                        <option>19</option>
                          <option>20</option>
                            <option>21</option>
                              <option>22</option>
                                <option>23</option>
                                  <option>24</option>
                                    <option>25</option>
                                      <option>26</option>
                                        <option>27</option>
                                          <option>28</option>
                                            <option>29</option>
                                              <option>30</option>
                                                <option>31</option>

        </select>
        <br>
        <br>
        <input type="checkbox" name="13ev" id="check" ><span id="but">Elmúltam 13 éves</span> <br>
        <br>

        <input id="kuldes" type="button" onclick="kuld()" class="btn" name="registerbutton" value="Regisztráció">





</form>

</body>
</html>

<script>
function kuld(){
	
	if(document.getElementById("user").value.length < 3 ){
		alert("A felhasználónév legyen minimum 3 karakter!");
		
	
	return;}
	if(document.getElementById("email").value.length < 3 ){
		alert("Az email legyen minimum 3 karakter!");
		return;
	}
	if(document.getElementById("password").value.length < 3 ){
		alert("A jelszo legyen minimum 3 karakter!");
		return;
	}
	if(document.getElementById("password2").value.length < 3 ){
		alert("A jelszo legyen minimum 3 karakter!");
		return;
	}
	
  $.post("regisztracio.php",
  {
    user: document.getElementById("user").value,
	
    email: document.getElementById("email").value,
	
	pwd: document.getElementById("password").value,
	
	pwd2: document.getElementById("password2").value
  },
  function(data, status){
	  console.log(data);
    if(data == "Siker"){
		window.location.replace("index.html");
		
		
	}
	else{
		alert("Nem egyezik meg a két jelszó :(");
	}
	
	
  });
}

</script>
