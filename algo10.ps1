function Get-PhoneNumberValidation([String]$PhoneNumber)
{

$format = @('^\(\d{3}\) \d{3}-\d{4}$') # (123) 456-7890 )
foreach($form in $format){
    if($PhoneNumber -match $form){return $true}
    else{$false}
}
}