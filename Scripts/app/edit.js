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
			if (data.success != null) {
			}
			else {

			}
		},
		error: function (data) {
		}
	});
}