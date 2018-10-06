function edit() {
	var user = {
		Id: $('#id').val(),
		FirstName: $('#firstname').val(),
		LastName: $('#lastname').val(),
		Email: $('#email').val(),
		Detail: {
			Address: $('#address').val(),
			Phone: $('#phone').val()
		}
	}

	$.ajax({
		type: "PUT",
		contentType: "application/json",
		url: '/User/Update/' + user.Id,
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