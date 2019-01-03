

Namespace SMPLibrary
    Public Enum FunRet As Integer
        Succeded = 1
        Failed = 2
        Exception = 3
    End Enum

    Public Enum DBConnectionStatus As Integer
        '     The connection is closed.
        Closed = 0
        '     The connection is open.
        Open = 1
    End Enum

    Public Enum ModelTypes As Integer
        JCEMODEL
        CUSTOMERSMODEL
        MILESTONESMODEL
        OPPORTUNITIESMODEL
        PLANTSMODEL
        PROJECTSMODEL
        PROJECTTEAMMODEL
        WBSMODEL
    End Enum
End Namespace