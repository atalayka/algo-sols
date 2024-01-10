function Summation([int] $n) {
    ($n * ($n + 1)) / 2
}
    
function Summation([int] $n) {

    [int[]]$x = 0..$n
    $x.ForEach({
            $Result += $PSItem
        })
        
    return $Result
        
}
        
Summation -n 10

function Summation([int] $n) {

    for ($i = $n; $i -gt 0; $i--) {
  
      $result += $i;
    }
  
    return $result
  }
  
  Summation -n 10