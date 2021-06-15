using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;


namespace AppHomeDepotUrielUriel
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, Icon="@drawable/ic_icon", RoundIcon ="@drawable/ic_icon_bg_round")]

    

    public class MainActivity : Activity
    {
        RecyclerView ReclicladorDeVista;
        RecyclerView.LayoutManager AdministradorInterfaz;
        PhotoAlbumAdapter Adaptador;
        AlbumFotos mAlbumFotos;
        
         
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            mAlbumFotos = new AlbumFotos();
            ReclicladorDeVista = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            AdministradorInterfaz = new LinearLayoutManager(this);
            //ReclicladorDeVista.SetLayoutManager(AdministradorInterfaz);
            ReclicladorDeVista.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Horizontal, false));
            Adaptador = new PhotoAlbumAdapter(mAlbumFotos);
            Adaptador.SeleccionElemento += OnItemClick;
            ReclicladorDeVista.SetAdapter(Adaptador);

          
        }
        void OnItemClick(object sender, int posicion)
        {
            var txtSKU = FindViewById<TextView>(Resource.Id.txtsku);
            var txtModelo = FindViewById<TextView>(Resource.Id.txtmodelo);
            var txtNombre = FindViewById<TextView>(Resource.Id.txtnombre);
            var txtDescripcion = FindViewById<TextView>(Resource.Id.txtdespripcion);
            var txtPrecio = FindViewById<TextView>(Resource.Id.txtprecio);


            int NumeroDeFoto = posicion + 1;
            Toast.MakeText(this, "Fotografía" + NumeroDeFoto, ToastLength.Short).Show();

            if (NumeroDeFoto == 1)
            {
                txtSKU.Text = "SKU#124286";
                txtModelo.Text = "Modelo: SS1213";
                txtNombre.Text = "Nombre: PISO VINÍLICO AUTOADHERIBLE SLATE GRAY";
                txtDescripcion.Text = "Descripción: 40.64 X 40.64 CM";
                txtPrecio.Text = "Precio: $277.22 m²";
            }
            else
            {
                if (NumeroDeFoto == 2)
                {
                    txtSKU.Text = "SKU#124284";
                    txtModelo.Text = "Modelo: SS4401";
                    txtNombre.Text = "Nombre: PISO VINÍLICO AUTOADHERIBLE";
                    txtDescripcion.Text = "Descripción: 2.81 M2 MÁRMOL";
                    txtPrecio.Text = "Precio: $277.22 m²";
                }
                else
                {
                    if (NumeroDeFoto == 3)
                    {
                        txtSKU.Text = "SKU#124270";
                        txtModelo.Text = "Modelo:SS2380";
                        txtNombre.Text = "Nombre: PISO VINÍLICO TRAVERTINE";
                        txtDescripcion.Text = "Descripción: 30.48 X 30.48 CM";
                        txtPrecio.Text = "Precio: $277.78 m²";
                    }
                    else
                    {
                        if (NumeroDeFoto == 4)
                        {
                            txtSKU.Text = "SKU#124260";
                            txtModelo.Text = "Modelo: PA82055";
                            txtNombre.Text = "Nombre: PISO VINÍLICO AUTOADHERIBLE DARK OAK";
                            txtDescripcion.Text = "Descripción: 30.48 X 30.48 CM CAJA CON 4.18 M2";
                            txtPrecio.Text = "Precio: $209.33 m²";
                        }
                        else
                        {
                            if (NumeroDeFoto == 5)
                            {
                                txtSKU.Text = "SKU#124259";
                                txtModelo.Text = "Modelo: PA8215";
                                txtNombre.Text = "Nombre: PISO VINÍLICO AUTOADHERIBLE";
                                txtDescripcion.Text = "Descripción: 30.48 X 30.48 CM";
                                txtPrecio.Text = "Precio: $209.33 m²";
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
        }
    }
    public class Fotografias
    {
        public int mFotoID;
        public string mTextoFoto;
        public int FotoID { get { return mFotoID; } }
        public string TextFoto { get { return mTextoFoto; } }
    }

    public class AlbumFotos
    {
        private Fotografias[] Fotos;
        public AlbumFotos()
        {
            Fotos = ConjuntoDeFotos;
        }
        public int CantidadDeFotos
        {
            get { return Fotos.Length; }
        }
        public Fotografias this[int i]
        {
            get { return Fotos[i]; }
        }
        static Fotografias[] ConjuntoDeFotos =
       {
            new Fotografias{mFotoID = Resource.Drawable.uno,
            mTextoFoto="Slate Gray"},
            new Fotografias{mFotoID = Resource.Drawable.dos,
            mTextoFoto="Crema Marble"},
            new Fotografias{mFotoID = Resource.Drawable.tres,
            mTextoFoto="Travertine"},
            new Fotografias{mFotoID = Resource.Drawable.cuatro,
            mTextoFoto="Dark Oak"},
            new Fotografias{mFotoID = Resource.Drawable.cinco,
            mTextoFoto="Gunstock"},            
        };
    }
}