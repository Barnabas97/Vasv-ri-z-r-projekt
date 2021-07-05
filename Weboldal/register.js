	$(document).ready(function(){
	$('input').blur(function(){
				$(this).css("background-color", "white");

				var adat = $('#adat').text();
				adat += $('#user').val();
				adat += $('#pwd').val();

				$('#adat').text(adat);
			})

			$('input').blur(function(){
				var nev = $(this).attr('name');
				var ertek = $(this).val();
				if (nev == 'user'){
					if (ertek.length < 8){
						$('#userErr').html('A felhasználónév legalább 8 karakter hosszú legyen!');
					}
				}

				if (nev == 'user'){
					if (ertek.length >= 8){
						$('#userErr').html(' ');
					}
				}

				if(nev == 'user'){
					if($.isNumeric(ertek[0]))
					{
						$('#userErr').html('A felhasználónév nem kezdődhet számmal!');

					}

				}

				if(nev == 'user'){


						if (ertek.search(/[0-9]/) < 0) {

							$('#userErr').html('A felhasználónévnek tartalmaznia kell számot!');

						}

				}



				if(nev == 'user'){


						if (ertek.search(/[a-zA-Z]/) < 0) {

							$('#userErr').html('A felhasználónévnek tartalmaznia kell betűket!');

						}

				}





				if (nev == 'pwd'){
					if (ertek.length < 8){
						$('#jelszoErr').html('A jelszó legalább 8 karakter hosszú legyen!');
					}
				}



				if (nev == 'pwd'){
					if (ertek.length >= 8){
						$('#jelszoErr').html(' ');
					}
				}

				if(nev == 'pwd'){
					if (ertek.search(/[a-z]/) < 0) {
  				$('#jelszoErr').html("A jelszónak kisbetűt is kell tartalmaznia")


				}

			}

			if(nev == 'pwd'){
				if (ertek.search(/[A-Z]/) < 0) {
				$('#jelszoErr').html("A jelszónak nagybetűt is kell tartalmaznia")


			}

		}


		if(nev == 'pwd'){
			if (ertek.search(/[0-9]/) < 0) {
			$('#jelszoErr').html("A jelszónak számot is kell tartalmaznia")


		}

	}

	if(nev == 'pwd'){
		if (ertek.search(/[*,%,?,!]/) < 0) {
		$('#jelszoErr').html("A jelszónak *,%,?! közül valamelyiket tartalmazni kell")


	}

}

	if(nev == 'iranyitoszam'){
		if(ertek.search(/[1-9][0-9]{3}/) < 0){
						$('#iranyitoErr').html('Az irányítószám 1000 és 9999 közötti érték kell legyen!')

	}
	else
	$('#iranyitoErr').html(' ')

}


if(nev == 'email'){
   					var x = document.forms["regisztrálás"]["email"].value;
  					  var atpos = x.indexOf("@");
 					   var dotpos = x.lastIndexOf(".");
   						 if (atpos<1 || dotpos<atpos+2 || dotpos+2>=x.length) {
      					  $('#EmailErr').html('Az email-cím nem megfelelő a követelményeknek');
     					   return false;
						   }
						   else{
						   		$('#EmailErr').html(' ');
     					   return true;
						   }
				}

				$('#Checkboxok :checkbox').change(function () {
			var checkedCheckBoxes = $(this).parent().find(':checkbox:checked');
			if (checkedCheckBoxes.length < 2) {
				$("#CheckboxErr").html("Legalább 2 érdeklődési kört meg kell jelölnie!");
			}
			else {
				$("#CheckboxErr").html(' ');
			}
			});


			$('#Radibuttonok :radio').change(function () {
		var checkedRadiobuttons = $(this).parent().find(':radio:checked');
		if (checkedRadiobuttons.length < 1) {
			$("#RadioErr").html("Legalább 1 nem legyen kiválasztva!");
		}
		else {
			$("#RadioErr").html(' ');
		}
		});








			})

			//$('body').text('Helló Világ'); //A teljes body-t felülírja


			$('p').on('click', function() {
				$(this).css('background-color','darkblue');
				$(this).css('color','white');
			});

		});
