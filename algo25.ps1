function nb-dig($n, $d) {
  $count = 0
  for ($k = 0; $k -le $n; $k++) {
    $square = $k * $k
    $squareString = $square.ToString()
    for ($i = 0; $i -lt $squareString.Length; $i++) {
      if ($squareString[$i] -eq $d.ToString()) {
        $count++
      }
    }
  }
  return $count
}