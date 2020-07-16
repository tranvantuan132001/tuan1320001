<?php

use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});
Route::get('/',function (){
   return view( 'hi');
});
Route::get('Profile/{name}','ProfileController@showProfile');

Route::get('/insert',function (){
    DB::insert('insert into posts(name,price,imaFull) values (?,?)',['áo sơ mi','500 vnd']);
});
Route::get('/insert',function (){
    DB::insert('insert into posts(name,price,imaFull) values (?,?)',['áo sơ mi','500 vnd']);
});
Route::get('/insert',function (){
    DB::insert('insert into posts(name,price,imaFull) values (?,?)',['áo sơ mi','500 vnd']);
});
Route::get('/update',function (){
   $updated= DB::update('update posts set name= "áo phông" where id > ?',[1]);
   return $updated;
});
Route::get('/update',function (){
    $updated= DB::update('update posts set price= "200$" where id > ?',[1]);
    return $updated;
});Route::get('/update',function (){
    $updated= DB::update('update posts set imgFull=  where id > ?',[1]);
    return $updated;
});
Route::get('/red',function (){
$result = DB::select('select * from posts where id >=?',[1]);
return $result;
});
Route::get('/deleted',function (){
   $deleted = DB::delete('delete * from post where id = ?',[3]);
});
