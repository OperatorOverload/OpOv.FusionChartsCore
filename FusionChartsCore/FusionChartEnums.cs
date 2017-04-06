using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionChartsCore
{
    /// <summary>
    /// User configurable chart parameter list 
    /// </summary>
    public enum LegacyChartParameters
    {
        chartType,
        chartId,
        chartWidth,
        chartHeight,
        dataFormat,
        dataSource,
        renderAt,
        bgColor,
        bgOpacity
    }

    /// <summary>
    /// List of supported data formats
    /// </summary>
    public enum DataFormat
    {
        json,
        jsonurl,
        xml,
        xmlurl,
        csv
    }

    /// <summary>
    /// List of supported chart types
    /// </summary>
    public enum ChartType
    {
        column2d,
        column3d,
        line,
        area2d,
        bar2d,
        bar3d,
        pie2d,
        pie3d,
        doughnut2d,
        doughnut3d,
        pareto2d,
        pareto3d,
        mscolumn2d,
        mscolumn3d,
        msline,
        msbar2d,
        msbar3d,
        msarea,
        marimekko,
        zoomline,
        zoomlinedy,
        stackedcolumn2d,
        stackedcolumn3d,
        stackedbar2d,
        stackedbar3d,
        stackedarea2d,
        msstackedcolumn2d,
        mscombi2d,
        mscombi3d,
        mscolumnline3d,
        stackedcolumn2dline,
        stackedcolumn3dline,
        mscombidy2d,
        mscolumn3dlinedy,
        stackedcolumn3dlinedy,
        msstackedcolumn2dlinedy,
        scatter,
        zoomscatter,
        bubble,
        scrollcolumn2d,
        scrollline2d,
        scrollarea2d,
        scrollstackedcolumn2d,
        scrollcombi2d,
        scrollcombidy2d,
        angulargauge,
        bulb,
        cylinder,
        hled,
        hlineargauge,
        thermometer,
        vled,
        realtimearea,
        realtimecolumn,
        realtimeline,
        realtimestackedarea,
        realtimestackedcolumn,
        realtimelinedy,
        sparkline,
        sparkcolumn,
        sparkwinloss,
        hbullet,
        vbullet,
        funnel,
        pyramid,
        gantt,
        logmscolumn2d,
        logmsline,
        spline,
        splinearea,
        msspline,
        mssplinearea,
        errorbar2d,
        errorline,
        errorscatter,
        inversemsarea,
        inversemscolumn2d,
        inversemsline,
        dragcolumn2d,
        dragline,
        dragarea,
        treemap,
        radar,
        heatmap,
        boxandwhisker2d,
        candlestick,
        dragnode,
        msstepLine,
        multiaxisline,
        multilevelpie,
        selectscatter,
        waterfall2d,
        kagi
    }
}
