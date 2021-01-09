
function function_ThongTinCaNhan() {
    var ThongTinCaNhan = document.getElementById("ThongTinCaNhan");
    ThongTinCaNhan.classList.add("active");
    var cl = document.getElementById("ThongTinCaNhan").className;
    alert(cl.includes("active"));
}

function function_DonDatHang() {
    var DonDatHang = document.getElementById("DonDatHang");
    // DonDatHang.classList.add("active");
    var cl = document.getElementById("DonDatHang").className;
    alert(cl.includes("active"));
}

function function_GioHangCuaToi() {
    var GioHangCuaToi = document.getElementById("GioHangCuaToi");
    GioHangCuaToi.classList.add("active");
}

function function_SanPhamDoiTra() {
    var SanPhamDoiTra = document.getElementById("SanPhamDoiTra");
    SanPhamDoiTra.classList.add("active");
}

function function_DanhSachYeuThich() {
    var DanhSachYeuThich = document.getElementById("DanhSachYeuThich");
    DanhSachYeuThich.classList.add("active");
}

function switchPage(id) {
    var ThongTinCaNhan = document.getElementById("ThongTinCaNhan");
    var DonDatHang = document.getElementById("DonDatHang");
    var GioHangCuaToi = document.getElementById("GioHangCuaToi");
    var SanPhamDoiTra = document.getElementById("SanPhamDoiTra");
    var DanhSachYeuThich = document.getElementById("DanhSachYeuThich");

    var cl_ThongTinCaNhan = ThongTinCaNhan.className;
    var cl_DonDatHang = DonDatHang.className;
    var cl_GioHangCuaToi = GioHangCuaToi.className;
    var cl_SanPhamDoiTra = SanPhamDoiTra.className;
    var cl_DanhSachYeuThich = DanhSachYeuThich.className;

    var isActive_ThongTinCaNhan = cl_ThongTinCaNhan.includes("active");
    var isActive_DonDatHang = cl_DonDatHang.includes("active");
    var isActive_GioHangCuaToi = cl_GioHangCuaToi.includes("active");
    var isActive_SanPhamDoiTra = cl_SanPhamDoiTra.includes("active");
    var isActive_DanhSachYeuThich = cl_DanhSachYeuThich.includes("active");

    

    if (id === "ThongTinCaNhan") {
        if (!isActive_ThongTinCaNhan) {
            ThongTinCaNhan.classList.add("active");
        }
        DonDatHang.classList.remove("active");
        GioHangCuaToi.classList.remove("active");
        SanPhamDoiTra.classList.remove("active");
        DanhSachYeuThich.classList.remove("active");
    }
    if (id === "DonDatHang") {
        if (!isActive_DonDatHang) {
            DonDatHang.classList.add("active");
        }
        ThongTinCaNhan.classList.remove("active");
        GioHangCuaToi.classList.remove("active");
        SanPhamDoiTra.classList.remove("active");
        DanhSachYeuThich.classList.remove("active");
    }
    if (id === "GioHangCuaToi") {
        if (!isActive_GioHangCuaToi) {
            GioHangCuaToi.classList.add("active");
        }
        ThongTinCaNhan.classList.remove("active");
        DonDatHang.classList.remove("active");
        SanPhamDoiTra.classList.remove("active");
        DanhSachYeuThich.classList.remove("active");
    }
    if (id === "SanPhamDoiTra") {
        if (!isActive_SanPhamDoiTra) {
            SanPhamDoiTra.classList.add("active");
        }
        ThongTinCaNhan.classList.remove("active");
        GioHangCuaToi.classList.remove("active");
        DonDatHang.classList.remove("active");
        DanhSachYeuThich.classList.remove("active");
    }
    if (id === "DanhSachYeuThich") {
        if (!isActive_DanhSachYeuThich) {
            DanhSachYeuThich.classList.add("active");
        }
        ThongTinCaNhan.classList.remove("active");
        GioHangCuaToi.classList.remove("active");
        SanPhamDoiTra.classList.remove("active");
        DonDatHang.classList.remove("active");

    }

}

