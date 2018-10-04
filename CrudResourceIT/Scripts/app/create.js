function create() {
	var user = {
		FirstName: $('#firstname').val(),
		LastName: $('#lastname').val(),
		Email: $('#email').val(),
		Detail: {
			Address: $('#address').val(),
			Phone: $('#phone').val()
		}
	}

	//fazer validação de campos
	//se tiver tudo ok faça..
	$.ajax({
		type: "POST",
		contentType: "application/json",
		url: '/User/Create',
		data: JSON.stringify(user),
		success: function (data) {
			if (data.success != null) {
			}
			else {

			}
		},
		error: function (data) {
		}
	});
}