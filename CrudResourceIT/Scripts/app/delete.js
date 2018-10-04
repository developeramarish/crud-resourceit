function excluir(id) {
	$.ajax({
		type: "DELETE",
		contentType: "application/json",
		url: '/User/Delete/' + id,
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