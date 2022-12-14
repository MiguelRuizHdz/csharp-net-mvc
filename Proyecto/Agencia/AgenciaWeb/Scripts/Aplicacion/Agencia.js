

var Automovil = {
    LimpiarAutomovil: function () {},
    MostrarAutomovilModal: function () {
        $('#mdlAgregaAutomovil').modal('show');
    },
    MostrarAutomovilModal2: function () {
        $('#mdlActualizarAutomovil').modal('show');
    },
    CerrarAutomovilModal: function () {
        $('#mdlAgregaAutomovil').modal('hide');
    }
};

$(document).ready(function () {
    consultarAutomovil();
});

$('#btnAgregarAutomovil').on('click', function (e) {
    e.preventDefault();
    Automovil.MostrarAutomovilModal();
});

$('#btnActualizarAutomovil').on('click', function (e) {
    e.preventDefault();
    Automovil.MostrarAutomovilModal2();
});

$('#btnAgregarAutomovil_2').on('click', function (e) {
    e.preventDefault();
    InsertarAutomovil_2();
});

$('#btnActualizarAutomovil_2').on('click', function (e) {
    e.preventDefault();
    ActualizarAutomovil();
});

$('#btnBuscarAutomovil').on('click', function (e) {
    e.preventDefault();
    BuscarAutomovil_2();
});

function ActualizarAutomovil() {
    var automovilId = $('#Id').val().trim();
    var marca = $('#a_marca').val().trim();
    var modelo = $('#a_modelo').val().trim();
    var anio = $('#a_anio').val().trim();
    var precio = $('#a_precio').val().trim();
    var data = { automovilId, marca, modelo, anio, precio };
    jsonServerResponse(_actualizarAutomovil, data,
        function (beforeSend) {   
        },
        function (response) {  
            if (response.success === true ) {
                $('#mdlActualizarAutomovil').modal('hide');
                alert('Registro actualizado correctamente');
                consultarAutomovil();
            }
        },
        function (error) {   
            alert('Registro actualizado error');
        },
        function (complete) {   
        }
    );
}

function InsertarAutomovil_2() {
    var marca = $('#marca').val().trim();
    var modelo = $('#modelo').val().trim();
    var anio = $('#anio').val().trim();
    var precio = $('#precio').val().trim();
    var data = { marca, modelo, anio, precio };
    jsonServerResponse(_insertarAutomovil, data,
        function (beforeSend) {   
        },
        function (response) {  
            if (response.success === true ) {
                $('#mdlAgregaAutomovil').modal('hide');
                alert('Registro agregado correctamente');
                consultarAutomovil();
            }
        },
        function (error) {   
            alert('Registro agregado error');
        },
        function (complete) {   
        }
    );
}

function BuscarAutomovil_2() {
    var automovilId = $('#Id').val().trim();
    var data = { automovilId };
    jsonServerResponse(_consultarAutomovilXId, data,
        function (beforeSend) { },
        function (response) {  
            if (response.success === true ) {
                $('#a_marca').val(response.data.Data.Marca);
                $('#a_modelo').val(response.data.Data.Modelo);
                $('#a_anio').val(response.data.Data.Anio);
                $('#a_precio').val(response.data.Data.Precio);
            }
        },
        function (error) {   
            alert('Error');
        },
        function (complete) {   
        }
    );
}

function consultarAutomovil() {
    var data = {};
    jsonServerResponse(_consultarAutomovil, data,
        function (beforeSend) { },
        function (response) {  
            $('#dtAutomovilBody').empty();
            console.log(response);
            for (var i = 0; i < response.Data.length; i++) {
                $('#dtAutomovilBody').append(
                    '<tr>' +
                    '<td style="width: 20%"> '+ response.Data[i].AutomovilId + '</td>' +
                    '<td style="width: 20%"> '+ response.Data[i].Marca + '</td>' +
                    '<td style="width: 20%"> '+ response.Data[i].Modelo + '</td>' +
                    '<td style="width: 20%"> '+ response.Data[i].Anio + '</td>' +
                    '<td style="width: 20%"> '+ response.Data[i].Precio + '</td>' +
                    '</tr>'
                );   
            }
        },
        function (error) {   
            alert('Ocurrió un error al consultar Automóvil');
            // Alerta.Mensaje(iconAlert['D'], 'Ocurrió un error al consultar Automóvil', typeAlert['D'], 'top', 'center');
        },
        function (complete) {   
        }
    );
}