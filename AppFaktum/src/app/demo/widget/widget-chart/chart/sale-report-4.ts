export class SaleReport4 {
  public static widgetChartData = {
    chart: {
      type: 'bar',
      height: 150,
      sparkline: {
        enabled: true
      }
    },
    dataLabels: {
      enabled: false
    },
    colors: ['#ffba57'],
    plotOptions: {
      bar: {
        columnWidth: '60%'
      }
    },
    series: [{
      data: [25, 66, 41, 89, 63, 25, 44, 12, 9, 54, 25, 66, 41, 69, 23]
    }],
    xaxis: {
      crosshairs: {
        width: 1
      },
    },
    tooltip: {
      fixed: {
        enabled: false
      },
      x: {
        show: false
      },
      y: {
        title: {
          formatter: (seriesName) => 'Yearly Sales :'
        }
      },
      marker: {
        show: false
      }
    }
  };
}
