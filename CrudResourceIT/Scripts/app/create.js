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
			$('#modal-success').modal();
			$('.modal-title').html("Sucesso!")
			$('.modal-body').html(data.message);
		},
		error: function (data) {
			$('#modal-danger').modal();
			$('.modal-title').html("Erro!")
            $('.modal-body').html(data.responseJSON.message);
		}
	});
}